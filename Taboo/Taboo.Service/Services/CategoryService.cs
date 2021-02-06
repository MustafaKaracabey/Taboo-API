using System;
using System.Collections.Generic;
using System.Text;
using Taboo.Core.Models;
using Taboo.Core.Repositories;
using Taboo.Core.Services;
using Taboo.Core.UnitOfWorks;

namespace Taboo.Service.Services
{
    public class CategoryService:Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWorks, IRepository<Category> repository)
         : base(unitOfWorks, repository)
        {

        }
    }
}
