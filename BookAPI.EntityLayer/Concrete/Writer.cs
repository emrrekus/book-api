using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.EntityLayer.Concrete
{
    public class Writer
    {
        public int WriterID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }

        // Book ile ilişki - Bir yazarın birden çok kitabı olabilir
        public List<Book> Books { get; set; }
    }
} 