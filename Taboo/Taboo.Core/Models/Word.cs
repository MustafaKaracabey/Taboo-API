using System;
using System.Collections.Generic;
using System.Text;

namespace Taboo.Core.Models
{
    public class Word 
    {
        public int WordId { get; set; }
        public string WordName { get; set; }
        public bool IsShown { get; set; }
        public bool DifficultyLevel { get; set; } // Logic : 1 -->Hard  0 -->Kolay

        public Word()
        {
            Tabus = new HashSet<Tabu>();
        }

        //Relationships
        public ICollection<Tabu> Tabus { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
