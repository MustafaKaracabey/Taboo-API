using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taboo.Core.Models;

namespace Taboo.Core.Repositories
{
    public interface IWordRepository:IRepository<Word>
    {
        Task<IEnumerable<Word>> GetAllWithTabusAsync();

    }
}
