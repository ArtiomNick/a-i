using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Employee
    {
        PersonalData personalData;
        Position position;
        Shift shift;

        public Employee(string name, int workingHours, int salaryPerHour, string positionName, string department, string shiftName, string startTime, string endTime)
        {
            personalData = new PersonalData(name, workingHours, salaryPerHour);
            position = new Position(positionName, department);
            shift = new Shift(shiftName, startTime, endTime);

        }

        public void GetDataAboutEmployee()
        {
            personalData.ShowPersonalData();
            position.ShowPositionData();
        }

        public void GetWorkTime()
        {
            shift.ShowShiftData();
        }
        
    }
}
