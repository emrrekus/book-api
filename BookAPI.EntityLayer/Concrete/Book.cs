using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.EntityLayer.Concrete
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Big_ImageUrl { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }

        // Writer ile ilişki - Bir kitabın bir yazarı olabilir
        public int WriterID { get; set; }
        public Writer Writer { get; set; }

        // Category ile ilişki - Bir kitabın bir kategorisi olabilir
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
} 