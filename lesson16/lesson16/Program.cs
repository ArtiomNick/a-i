using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            AdministrativeSingleton administrativeSingleton = AdministrativeSingleton.Instance;

            Employee employee1 = new Employee("name1", 40, 10, "dep1");
            Employee employee2 = new Employee("name2", 20, 8, "dep1");

            administrativeSingleton.AddEmployee(employee1);
            administrativeSingleton.AddEmployee(employee2);

            administrativeSingleton.ReadAllEmployees();
            float avg = administrativeSingleton.CalculateAvgSalary();
            Console.WriteLine(avg);

            employee1.SendMessage();
            employee2.SendMessage();


            Employee employee3 = FactoryForEmployee.CreateNewEmployeeWithoutDepartment("name1", 35, 12);
            Console.WriteLine($"Employee: {employee3.Name}, Salary: {employee3.Wage()}, Department: {employee3.Department}, Employed on: {employee3.DateOfEmployment}");

            Creatable<ServiceEmployee> factory1 = new ServEmplCreator();
            Creatable<AdministrativeEmployee> factory2 = new AdmEmplCreator();

            ServiceEmployee employee4 = factory1.FactoryMethod("name1", 35, 12, "dep2"); // ServiceEmployee
            Employee employee5 = factory2.FactoryMethod("name1", 25, 20, "dep2"); //AdministrativeEmployee

            

            Console.WriteLine("Hello World!");
            Console.ReadKey();



        }
    }

    class Phone
    {
        public string OS { get; set; }

        public int RAM { get; set; }

        public double Processor { get; set; }

        public int NumberOfNuclee { get; set; }

        public string CountryOrigin { get; set; }
    }

    class Samsung: Phone
    {

    }

    class SamsungFactory
    {
        public static Samsung CreateSamsungJ5(string countryOrigin)
        {
            var samsung = new Samsung()
            {
                OS = "Android",
                RAM = 2,
                Processor = 1.2,
                NumberOfNuclee = 4,
                CountryOrigin = countryOrigin
            };

            return samsung;
        }
    }

}
