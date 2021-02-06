using System;
using System.Collections.Generic;
using System.Text;
using Taboo.Core.Models;
using Taboo.Core.Repositories;

namespace Taboo.Data.Repositories
{
    public class CategoryRepository:Repository<Category>, ICategoryRepository
    {
        public EfDataContext EfDataContext { get => _context as EfDataContext; }

        public CategoryRepository(EfDataContext context)
            : base(context)
        {

        }
    }
}
