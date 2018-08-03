using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    class Employee : IWork
    {
        public string Name { get; }
        public string Department { get; }
        public int WorkingHours { get; }
        public int SalaryPerHour { get; }
        public int Wage() => WorkingHours * SalaryPerHour;
        //public int Wage { get { return WorkingHours * SalaryPerHour; } }
        public DateTime DateOfEmployment { get; set; } = DateTime.Now;

        public Employee()
        {

        }

        public Employee(string name, int workingHours, int salaryPerHour, string department)
        {
            this.Name = name;
            this.WorkingHours = workingHours;
            this.SalaryPerHour = salaryPerHour;
            this.Department = department;
        }

        public void CheckEmail()
        {
            Console.WriteLine($"Checking my mail");
        }

        public void DoAssignment()
        {
            Console.WriteLine("Implementing the assingment, working hard, rest not!");
        }

        public void CheckEvents()
        {
            Console.WriteLine("Checking the further events");
        }

        public void GoRest()
        {
            Console.WriteLine("Going to rest my bones");
        }

        public void GetSalary()
        {
            Console.WriteLine("Getting my waage");
        }
    }
}
