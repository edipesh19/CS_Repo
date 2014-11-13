using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Program
    {
        /// <summary>
        /// Demonstrating IEqualityComparer<> and IComparer<> interfaces
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var departments = new SortedDictionary<string, SortedSet<Employee>>();

            departments.Add("Engineering", new SortedSet<Employee>(new EmployeeComparer()));

            departments["Engineering"].Add(new Employee { Name = "Joy" });
            departments["Engineering"].Add(new Employee { Name = "Dani" });
            departments["Engineering"].Add(new Employee { Name = "Dani" });

            departments.Add("Sales", new SortedSet<Employee>(new EmployeeComparer()));

            departments["Sales"].Add(new Employee { Name = "Scot" });
            departments["Sales"].Add(new Employee { Name = "Alex" });
            departments["Sales"].Add(new Employee { Name = "Dani" });



            foreach (var department in departments)
            {
                Console.WriteLine(department.Key);
                foreach (var employee in department.Value)
                {
                    Console.WriteLine("\t" + employee.Name);
                }
            }



        }
    }
}
