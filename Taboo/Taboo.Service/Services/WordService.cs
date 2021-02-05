using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taboo.Core.Models;
using Taboo.Core.Repositories;
using Taboo.Core.Services;
using Taboo.Core.UnitOfWorks;

namespace Taboo.Service.Services
{
    public class WordService:Service<Word>, IWordService
    {
        public WordService(IUnitOfWork unitOfWorks, IRepository<Word> repository)
        : base(unitOfWorks,repository)
        {

        }

        public async Task<IEnumerable<Word>> GetAllWithTabusAsync()
        {
            return await _unitOfWork.Words.GetAllWithTabusAsync();
        }
    }
}

