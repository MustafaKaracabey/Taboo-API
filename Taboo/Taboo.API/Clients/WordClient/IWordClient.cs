using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taboo.API.Clients.Models;
using Taboo.Core.Models;

namespace Taboo.API.Clients.WordClient
{
    public interface IWordClient
    {
        Task<ResultClientModel<Word>> GetAllWithTabusAsync();
    }
}
