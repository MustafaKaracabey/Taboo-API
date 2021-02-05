using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taboo.API.Extensions
{
    public static  class SwaggerExtension
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1.0",
                    Title = "Taboo Web API",
                    Description = "A Simple Taboo Game  ASP.NET Core Web API",
                    TermsOfService = new System.Uri("https://www.linkedin.com/in/mustafa-karacabey-2046741a3/"),
                    Contact = new OpenApiContact() { Name = "Mustafa Karacabey", Email = "mustafa.karacabey@outlook.com" }
                });

            });
        }


        public static void UseCustomSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Taboo Web API");

            });
        }
    }
}
