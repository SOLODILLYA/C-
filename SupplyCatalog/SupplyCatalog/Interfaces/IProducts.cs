using SupplyCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyCatalog.Interfaces
{
    internal interface IProducts
    {
        //Iterface of operations with products

        List<Product> GetProductsByCategories(int categoryId);
        Product GetProduct(int productId);

        void AddEmp(Product product);

        void DelEmp(int productId);

        void ChangeEmp(Product product);
    }
}
