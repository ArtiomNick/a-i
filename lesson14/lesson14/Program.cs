using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lesson14
{

    class Program
    {
        static void Main(string[] args)
        {
            MethodForOptionalParameters("Ten is ");
            MethodForOptionalParametersAndNamedParameters(1, third: 2, second: 39, s: " is something ");
            //Immutable object
            OldEmployee oldEmployee = new OldEmployee("name", department: "dep", salary: 10);

            ExperimentsWithDynamic();

            WriteLine("\nExpresionBodiedMethods and converting to autoproperty and string interpolation");
            Employee employee1 = new Employee("name1", 40, 10, "dep1");

            WriteLine($"Employee: {employee1.Name}, Salary: {employee1.Wage()}, Department: {employee1.Department}, Employed on: {employee1.DateOfEmployment}");

            var employees = new Dictionary<string, Employee>()
            {
                ["first"] = employee1,
                ["second"] = employee1
            };

            WriteLine("\nNullConditionalOperator");
            oldEmployee.Salary = null;
            //OldEmployee oldEmployee1 = null;
            int needToKnowSalary = oldEmployee?.Salary ?? 10;
            WriteLine($"The wage is {needToKnowSalary}");

            WriteLine("\nOutVaribles");
            OutVariables(needToKnowSalary, out int value);
            WriteLine($"The wage is {value}");

            WriteLine("\nTuples");
            (int A, int B) t = Tuples();
            var (first, _) = Tuples();
            WriteLine($"{t.A}, {t.B}, {first}");

            WriteLine("\nImplicitConversions");
            double sal = needToKnowSalary;
            AdministrativeEmployee administrative = new AdministrativeEmployee("name1", 40, 10, "dep1");
            Employee empl = administrative;
            empl = new AdministrativeEmployee("name1", 40, 10, "dep1");

            WriteLine("\nExplicitConversions");
            sal = 10.000000001;
            needToKnowSalary = (int)sal;
            empl = new Employee("name1", 40, 10, "dep1");
            AdministrativeEmployee adm = null;
            Employee emp = null;
            adm = (AdministrativeEmployee)emp;

            administrative = empl as AdministrativeEmployee;

            empl = new Employee("name1", 40, 10, "dep1");
            administrative = new AdministrativeEmployee("name1", 40, 10, "dep1");

            WriteLine(administrative is Employee);      //True
            WriteLine(empl is AdministrativeEmployee);  //False

            ReadKey();
        }


        private static void MethodForOptionalParameters(string s, int ten = 9, bool _True = true)
        {
            WriteLine("MethodForOptionalParameters: ");
            int IsTenReallyTen(int nr)
            {
                if(nr != 10)
                {
                    nr = 10;
                }
                return nr;
            }
            ten = IsTenReallyTen(ten);
            WriteLine($"{s} {ten} is {nameof(_True)}");
        }

        private static void MethodForOptionalParametersAndNamedParameters(int first, int second, int third, string s = " is a number")
        {
            WriteLine("\nMethodForOptionalParametersAndNamedParameters: ");
            WriteLine(first + second + third + s);
        }

        private static void ExperimentsWithDynamic()
        {
            WriteLine("\nExperimentsWithDynamic");
            dynamic items = new List<string>() { "One", "Two", "Three" };
            dynamic valueToAdd = ",";
            foreach (dynamic item in items)
            {
                string result = item + valueToAdd;
                WriteLine(result);
            }
            dynamic d = 1;
            var testSum = d + 3;
            

            WriteLine(testSum);
        }

        private static void OutVariables(int input, out int value)
        {
            value = input + 1;
        }

        private static (int, int) Tuples()
        {
            return (1, 2);
        }

       

    }
}
