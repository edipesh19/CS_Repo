using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compare
{
    class EmployeeComparer:IEqualityComparer<Employee>,
        IComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(Employee obj)
        {
            return obj.Name.GetHashCode();
        }

        public int Compare(Employee x, Employee y)
        {
            return String.Compare(x.Name, y.Name);
        }
    }
}
