using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Position
    {
        public string PositionName { get; }
        public string Department { get; }

        public Position(string positionName, string department)
        {
            this.PositionName = positionName;
            this.Department = department;
        }

        public void ShowPositionData()
        {
            Console.WriteLine($"Position: {PositionName} in the department of {Department}");
        }
    }
}
