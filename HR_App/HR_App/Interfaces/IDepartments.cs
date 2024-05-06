using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_App.Models;

namespace HR_App.Interfaces
{
    public interface IDepartments
    {
        
        //Iterface of operations with departments
        List<Department> GetAllDeps();

        void AddDep(Department department);

        void ChangeDep(Department department);
    }
}
