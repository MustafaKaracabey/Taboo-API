using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taboo.Core.Models;

namespace Taboo.API.DTOs
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

       
        public ICollection<Word> Words { get; set; }
    }
}
