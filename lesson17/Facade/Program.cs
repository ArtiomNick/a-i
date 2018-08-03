using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Angela", 40, 10, "clerk", "groceries", "morning", "8:00", "17:00");

            employee.GetDataAboutEmployee();
            employee.GetWorkTime();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
