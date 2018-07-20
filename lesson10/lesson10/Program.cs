using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10
{
    class Program
    {



        static void Main(string[] args)
        {
            var myList = new List<int>();


            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            Console.WriteLine("Initial list: ");

            myList.ForEach(delegate (int value)
            {
                Console.Write(value + " ");
            });

            //Manipulate via delegates
            myList[0] = (int)Calculator.Calculate(myList[0], 10, Calculator.Add_Int);
            Console.WriteLine("\nValue modified: " + myList[0]);

            //Anonimous functions
            myList[0] = (int)Calculator.Calculate(myList[0], myList[1], delegate (object o1, object o2)
            {
                return (int)o1 - (int)o2;
            });
            Console.WriteLine("Value modified second time: " + myList[0]);

            //Lambda expresions
            myList[0] = (int)Calculator.Calculate(myList[0], myList[1], (object o1, object o2) =>
            {
                return (int)o1 - (int)o2;
            });
            Console.WriteLine("Value modified third time: " + myList[0]);

            var employees = new List<Employee>
            {
                new Employee(){ Name = "name1", Salary = 20, Department = "groceries" },
                new Employee(){ Name = "name2", Salary = 3, Department = "groceries" },
                new Employee(){ Name = "name3", Salary = 15, Department = "groceries" },
                new Employee(){ Name = "name4", Salary = 10, Department = "DELI" }
            };

            var dif = Calculator.CalculateWithLambdaExpresion(employees[0], employees[1], (a, b) =>
            {
                return ((Employee)a).Salary - ((Employee)b).Salary;
            });
            Console.WriteLine("Difference between two salaries: " + dif);

            //Extension methods
            var avgSalary = CalculationsForIntList.CalculateAvg(employees);

            Console.WriteLine("Average salary: " + avgSalary);

            //Using Select, Where operators on collection
            var filteredEmployees = employees.Where(e => e.Salary >= 10 & e.Department == "groceries")
                                              .OrderBy(e => e.Salary)
                                              .Select(e => new { Name = e.Name, Salary = e.Salary });
            Console.WriteLine("Filtered list of employees:");
            foreach (var employee in filteredEmployees)
            {
                Console.WriteLine("Name: {0}, Salary: {1} ",employee.Name, employee.Salary);
            }


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
