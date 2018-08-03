using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson16
{
    abstract class Creatable <T> where T : Employee
    {
        public abstract T FactoryMethod(string name, int workingHours, int salaryPerHour, string department);
    }
}
