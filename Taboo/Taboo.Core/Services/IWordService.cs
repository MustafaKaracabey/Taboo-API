using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taboo.Core.Models;

namespace Taboo.Core.Services
{
    public interface IWordService:IService<Word>
    {
        Task<IEnumerable<Word>> GetAllWithTabusAsync();
    }
}
