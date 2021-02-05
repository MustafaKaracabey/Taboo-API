using System;
using System.Collections.Generic;
using System.Text;

namespace Taboo.Core.Models
{
    public class Tabu
    {
        public int TabuId { get; set; }
        public string TabuName { get; set; }

        // 1 to Many Relationship
        public int WordId { get; set; }
        public Word Word { get; set; }

    }
}
