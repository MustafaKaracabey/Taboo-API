using System;
using System.Collections.Generic;
using System.Text;
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
    }
}

