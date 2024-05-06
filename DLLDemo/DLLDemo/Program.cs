using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DLLDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Create a reference to build
            Assembly assembly = Assembly.Load(AssemblyName.GetAssemblyName("ModelsLibrary.dll"));

            //2 - Create a reference to library module in a build
            Module targetModule = assembly.GetModule("ModelsLibrary.dll");

            //3 - Reading types of data from target DLL-Module
            Console.WriteLine("\n> Scan inside types of target DLL-Module");
            Type Human = targetModule.GetType("ModelsLibrary.Human") as Type;
            Type Address = targetModule.GetType("ModelsLibrary.Address") as Type;
            Type Employee = targetModule.GetType("ModelsLibrary.Employee") as Type;

            //4 - Create in dynamic mode example of type Address
            object addr = Activator.CreateInstance(Address, new object[]
            {
                "Ukraine", "Kyiv", "Zhylanska", "128", "3"
            });

            //5 - Create in dynamic mode example of type Human
            object human = Activator.CreateInstance(Human, new object[]
            {
                "Vasil Pupkin", 21, addr
            });

            //6 - Call method to change family status
            Human.GetMethod("ModifyStatus").Invoke(human, new object[]
            {
                FamilyStatus.Married
            });

            //7 - Call display method
            Human.GetMethod("Display").Invoke(human, null);

            //8 - Example of static download of types from DLL-Library
            Console.WriteLine("\n> Static using of DLL-Library");
            var emp = new Employee("Stepan Supkin", 27, new ModelsLibrary.Address("Ukraine", "Lviv", "Kyivska", "123", "12"), "Admin", 45000);
            emp.Display();
        }
    }
}
