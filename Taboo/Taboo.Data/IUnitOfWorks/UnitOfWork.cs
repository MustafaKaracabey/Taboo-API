using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taboo.Core.Repositories;
using Taboo.Core.UnitOfWorks;
using Taboo.Data.Repositories;

namespace Taboo.Data.IUnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EfDataContext _context;

        private  WordRepository _wordRepository;
        private  TabuRepository _tabuRepository;

        public ITabuRepository Tabus => _tabuRepository = _tabuRepository ?? new TabuRepository(_context);
        public IWordRepository Words => _wordRepository = _wordRepository ?? new WordRepository(_context);


        public UnitOfWork(EfDataContext efDataContext)
        {
            _context = efDataContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async  Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
