using System;
using System.Collections.Generic;
using System.Text;

namespace Taboo.Core.Models
{
    public class Word 
    {
        public int WordId { get; set; }
        public string WordName { get; set; }
        public bool DifficultyLevel { get; set; } // 1 -->Hard  0 -->Kolay

        public Word()
        {
            Tabus = new HashSet<Tabu>();
        }

        //1 To Many Relationship
        public ICollection<Tabu> Tabus { get; set; }

    }
}
