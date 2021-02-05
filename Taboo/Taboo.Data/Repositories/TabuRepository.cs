using System;
using System.Collections.Generic;
using System.Text;
using Taboo.Core.Models;
using Taboo.Core.Repositories;

namespace Taboo.Data.Repositories
{
    public class TabuRepository : Repository<Tabu>, ITabuRepository
    {

        public EfDataContext EfDataContext { get => _context as EfDataContext; }

        public TabuRepository(EfDataContext context)
            : base(context)
        {

        }
        
    }
}
