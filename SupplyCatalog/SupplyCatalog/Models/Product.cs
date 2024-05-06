using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyCatalog.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategotyId { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Photo { get; set; }
    }
}
