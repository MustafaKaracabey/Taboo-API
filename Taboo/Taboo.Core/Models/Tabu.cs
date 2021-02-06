using System;
using System.Collections.Generic;
using System.Text;

namespace Taboo.Core.Models
{
    public class Tabu
    {
        public int TabuId { get; set; }
        public string TabuName { get; set; }

        //Relationships
        public int WordId { get; set; }
        public Word Word { get; set; }

    }
}
