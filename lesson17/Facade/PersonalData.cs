using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class PersonalData
    {
        public string Name { get; } 
        public int WorkingHours { get; }
        public int SalaryPerHour { get; }
        public int Wage() => WorkingHours * SalaryPerHour;
        //public int Wage { get { return WorkingHours * SalaryPerHour; } }
        public DateTime DateOfEmployment { get; set; } = DateTime.Now;

        public PersonalData(string name, int workingHours, int salaryPerHour)
        {
            this.Name = name;
            this.WorkingHours = workingHours;
            this.SalaryPerHour = salaryPerHour;

        }

        public void ShowPersonalData()
        {
            Console.WriteLine($"{Name}: Salary:{Wage()}");
        }
    }
}
