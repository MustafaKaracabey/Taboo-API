using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taboo.Core.Models;
using Taboo.Core.Repositories;

namespace Taboo.Data.Repositories
{
    public class WordRepository: Repository<Word>,IWordRepository
    {

        public EfDataContext EfDataContext { get => _context as EfDataContext; }

        public WordRepository(EfDataContext context)
            : base(context)
        {

        }

        public async Task<IEnumerable<Word>> GetAllWithTabusAsync()
        {
            return await EfDataContext.Words
               .Include(a => a.Tabus)
               .ToListAsync();
        }

        
    }
}
