using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    class InternProxy : IWork
    {
        private Employee employee = new Employee();

        public void CheckEmail()
        {
            employee.CheckEmail();
        }

        public void CheckEvents()
        {
            employee.CheckEvents();
        }

        public void DoAssignment()
        {
            employee.DoAssignment();
        }

        public void GoRest()
        {
            employee.GoRest();
        }

        public void GetSalary()
        {
            Console.WriteLine("Not employed yet");
        }
    }
}
