using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson16
{
    class AdministrativeEmployee : Employee
    {
        public AdministrativeEmployee(string name, int workingHours, int salaryPerHour, string department) : base (name, workingHours, salaryPerHour, department)
        {
            Console.WriteLine("Hi i'm an administrative employee and i was created");
        }



    }
}
