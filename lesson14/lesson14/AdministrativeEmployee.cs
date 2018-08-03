using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14
{
    class AdministrativeEmployee : Employee
    {
        public AdministrativeEmployee(string name, int workingHours, int salaryPerHour, string department) : base(name, workingHours, salaryPerHour, department)
        {
        }

    }
}
