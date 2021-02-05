using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Taboo.API.Extensions;
using Taboo.Core.Repositories;
using Taboo.Core.Services;
using Taboo.Core.UnitOfWorks;
using Taboo.Data;
using Taboo.Data.IUnitOfWorks;
using Taboo.Data.Repositories;
using Taboo.Service;
using Taboo.Service.Services;

namespace Taboo.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Adding Swagger Service For Docs
            services.AddSwagger();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));

            services.AddScoped<IWordService,WordService>();
            services.AddScoped<ITabuService, TabuService>();


            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<EfDataContext>(
                options =>
                options.UseSqlServer("name=ConnectionStrings:DefaultConnection", o => { o.MigrationsAssembly("Taboo.Data"); })
                );

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //Add Swagger MiddleWare
            app.UseCustomSwagger();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
