using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("name1", 40, 10, "dep1");
            Employee employee2 = new Employee("name2", 20, 8, "dep1");

            var employeeList = new ListForCalculatingAverageSalary();
            employeeList.Add(employee1);
            employeeList.Add(employee2);

            employeeList.SetCalculationStrategy(new CalculateMonthlyAvgSalary());
            Console.WriteLine(employeeList.CalculateAvgSalary());

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
