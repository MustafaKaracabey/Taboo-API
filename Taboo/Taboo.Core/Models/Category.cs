using System;
using System.Collections.Generic;
using System.Text;

namespace Taboo.Core.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public Category()
        {
            Words = new HashSet<Word>();

        }
        //Relationships
        public ICollection<Word> Words { get; set; }

      
    }
}
