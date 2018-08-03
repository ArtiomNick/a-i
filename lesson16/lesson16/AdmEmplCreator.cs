using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson16
{
    class AdmEmplCreator : Creatable <AdministrativeEmployee>
    {
        public override AdministrativeEmployee FactoryMethod(string name, int workingHours, int salaryPerHour, string department)
        {
            return new AdministrativeEmployee(name, workingHours, salaryPerHour, department);
        }
    }
}
