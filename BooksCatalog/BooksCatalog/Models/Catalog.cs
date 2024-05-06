using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksCatalog.Models
{
    public class Catalog
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Catalog() { 
            Books = new List<Book>();
        }
    }
}
