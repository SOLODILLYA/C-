using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_App.Models;

namespace HR_App.Interfaces
{
    public interface IEmployees
    {
        //Iterface of operations with employees

        List<Employee> GetEmpsByDep(int depId);
        Employee GetEmp(int empId);

        void AddEmp(Employee emp);

        void DelEmp(int EmpId);

        void ChangeEmp(Employee emp);
    }
}
