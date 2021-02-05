using System;
using System.Collections.Generic;
using System.Text;
using Taboo.Core.Models;
using Taboo.Core.Repositories;
using Taboo.Core.Services;
using Taboo.Core.UnitOfWorks;

namespace Taboo.Service.Services
{
    public class TabuService : Service<Tabu>, ITabuService
    {
        public TabuService(IUnitOfWork unitOfWorks, IRepository<Tabu> repository)
         : base(unitOfWorks, repository)
        {

        }
    }
}
