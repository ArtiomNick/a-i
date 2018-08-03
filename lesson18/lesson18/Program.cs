using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("name1", 40, 10, "dep1", "day", "8:00", "17:00");
            Employee employee2 = new Employee("name2", 20, 8, "dep1", "night", "13:00", "21:00");

            ShiftManager shiftManager = new ShiftManager();
            shiftManager.Attach(employee1);
            shiftManager.Attach(employee2);

            Shift nightShift = new Shift("night", "17:00", "23:00");
            shiftManager.SetNewShift(nightShift);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
