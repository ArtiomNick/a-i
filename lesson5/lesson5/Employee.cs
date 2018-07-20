using System;

namespace lesson5
{

    public abstract class Employee
    {
        public static int AvgSalary;

        string name;
        int workHours;
        //string birthDate;
        //string adress;
        //string phone;
        string breakTime;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int WorkHours
        {
            get { return workHours; }
            set { workHours = value; }
        }

        public string BreakTime
        {
            get { return breakTime; }
            set { breakTime = value; }
        }

        public int Salary
        {
            get { return workHours * AvgSalary; }
        }

        public void GetSalary()
        {
            Console.WriteLine("I got " + Salary);
        }

        public void GetSalary(int bonus)
        {
            int total = Salary + bonus;
            Console.WriteLine("I got " + total);
        }

        public void Rest()
        {
            Console.WriteLine("Start my break at " + BreakTime);
        }

    }

}
