using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{


    public class Employee
    {
        public string Name { set; get; }
        public int Salary { set; get; }
        public string Department { set; get; }
        public Shift Shift;

    }

    class EmployeeEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            return x.Name == y.Name && x.Salary == y.Salary && x.Department == y.Department;
        }

        public int GetHashCode(Employee obj)
        {
            return (obj.Name + ";" + obj.Salary + ";" + obj.Department).GetHashCode();
        }
    }

    class SalaryComparer : Comparer<Employee>
    {
        public override int Compare(Employee x, Employee y)
        {
            if (Equals(x, y))
            {
                return 0;
            }

            return x.Salary.CompareTo(y.Salary);



        }
    }
}
