using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson16
{
    class ServEmplCreator : Creatable <ServiceEmployee>
    {
        public override ServiceEmployee FactoryMethod(string name, int workingHours, int salaryPerHour, string department)
        {
            return new ServiceEmployee(name, workingHours, salaryPerHour, department);
        }
    }
}
