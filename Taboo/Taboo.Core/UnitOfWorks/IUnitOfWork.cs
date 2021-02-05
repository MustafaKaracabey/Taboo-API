using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taboo.Core.Repositories;

namespace Taboo.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        public IWordRepository Words { get;  }
        public ITabuRepository Tabus { get;  }

        Task CommitAsync();
        void Commit();
    }
}
