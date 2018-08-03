using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14
{
    public class OldEmployee
    {
        public string Name { get; }
        public int? Salary { get; set; }
        public string Department { get; }

        public OldEmployee(string name, int salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;

        }
       
    }
}
