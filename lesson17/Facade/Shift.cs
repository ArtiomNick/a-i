using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Shift
    {
        public string ShiftName { get; }
        public string StartTime { get; }
        public string EndTime { get; }

        public Shift(string shiftName, string startTime, string endTime)
        {
            this.ShiftName = shiftName;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        public void ShowShiftData()
        {
            Console.WriteLine($"On {ShiftName} shift, starting on {StartTime}, ending on {EndTime}");
        }
    }
}
