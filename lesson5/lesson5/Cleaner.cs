using System;

namespace lesson5
{
    partial class Program
    {
        public class Cleaner : ServiceStaff
        {
            public Cleaner(string name, int workHours, string breakTime, string department)
            {
                Name = name;
                WorkHours = workHours;
                BreakTime = breakTime;
                Department = department;
            }
            public override void StuffPreparations()
            {
                Console.WriteLine("Prepare chemicals and other goods");    
            }
        }
    }
}
