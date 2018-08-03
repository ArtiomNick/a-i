using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson16
{
    class FactoryForEmployee
    {
        public static Employee CreateNewEmployee(string name, int workingHours, int salaryPerHour, string department)
        {
            return new Employee(name, workingHours, salaryPerHour, department);
        }

        public static Employee CreateNewEmployeeWithoutDepartment(string name, int workingHours, int salaryPerHour)
        {
            return new Employee(name, workingHours, salaryPerHour, "NoDepartment");
        }

    }
}
