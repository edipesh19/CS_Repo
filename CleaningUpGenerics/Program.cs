using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningUpGenerics
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var departments = new DepartmentCollection();

            departments.Add("Engineering", new Employee {  Name = "Joy"})
                       .Add("Engineering", new Employee { Name = "Dani" })
                       .Add("Engineering", new Employee { Name = "Dani" });

            departments.Add("Sales", new Employee { Name = "Scot" })
                       .Add("Sales", new Employee { Name = "Alex" })
                       .Add("Sales", new Employee { Name = "Dani" });



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
