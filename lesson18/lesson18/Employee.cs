using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18
{
    class Employee : IObserver
    {
        public string Name { get; }
        public string Department { get; }
        public int WorkingHours { get; }
        public int SalaryPerHour { get; }
        public int Wage() => WorkingHours * SalaryPerHour;
        //public int Wage { get { return WorkingHours * SalaryPerHour; } }
        public DateTime DateOfEmployment { get; set; } = DateTime.Now;

        private Shift shift;

        public Employee()
        {

        }

        public Employee(string name, int workingHours, int salaryPerHour, string department, string shiftName, string startTime, string endTime)
        {
            this.Name = name;
            this.WorkingHours = workingHours;
            this.SalaryPerHour = salaryPerHour;
            this.Department = department;
            this.shift = new Shift(shiftName, startTime, endTime);
        }


        public void Update(Shift shift)
        {
            this.shift = shift;
            Console.WriteLine(string.Format("Employee {0} - New shift: {1}", Name, shift.ShowShiftData()));
        }
    }
}
