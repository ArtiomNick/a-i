using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            InternProxy intern = new InternProxy();
            Employee employee = new Employee();
            employee.CheckEmail();
            intern.CheckEmail();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
