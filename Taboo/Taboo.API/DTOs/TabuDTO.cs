using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taboo.Core.Models;

namespace Taboo.API.DTOs
{
    public class TabuDTO
    {
        public int TabuId { get; set; }
        public string TabuName { get; set; }

      
        public int WordId { get; set; }
        public Word Word { get; set; }
    }
}
