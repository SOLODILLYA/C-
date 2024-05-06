using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupplyCatalog.Models;

namespace SupplyCatalog.Interfaces
{
    public interface ICategories
    {
        //Iterface of operations with categories
        List<Category> GetAllCategories();

        void AddCategory(Category category);

        void ChangeCategory(Category category);
    }
}
