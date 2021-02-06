using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taboo.Core.Models;

namespace Taboo.API.DTOs
{
    public class WordDTO
    {
        public int WordId { get; set; }
        public string WordName { get; set; }
        public bool IsShown { get; set; }
        public bool DifficultyLevel { get; set; } 

      
        public ICollection<Tabu> Tabus { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
