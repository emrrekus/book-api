using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }

        // Book ile ilişki - Bir kategorinin birden çok kitabı olabilir
        public List<Book> Books { get; set; }
    }
} 