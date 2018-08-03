using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18
{
    class ShiftManager
    {
        private readonly List<IObserver> employees;

        private Shift shift;
        
        public void SetNewShift(Shift shift)
        {
            this.shift = shift;
            Notify();
        }

        public ShiftManager()
        {
            employees = new List<IObserver>();
        }

        public void Attach(IObserver employee)
        {
            if (!employees.Contains(employee))
            {
                employees.Add(employee);
            }
        }

        public void Detach(IObserver employee)
        {
            if (employees.Contains(employee))
            {
                employees.Remove(employee);
            }
        }

        private void Notify()
        {
            foreach(var employee in employees)
            {
                employee.Update(shift);
            }
        }

    }
}
