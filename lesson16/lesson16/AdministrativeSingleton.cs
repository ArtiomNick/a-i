using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson16
{
    class AdministrativeSingleton
    {
        private static AdministrativeSingleton instance = null;
        private static readonly object padlock = new object();
        private List<Employee> employees = new List<Employee>();

        private AdministrativeSingleton()
        {

        }

        public static AdministrativeSingleton Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new AdministrativeSingleton();
                        }
                    }
                }
                return instance;
            }
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            
        }

        public void ReadAllEmployees()
        {
            foreach(Employee empl in employees)
            {
                Console.WriteLine($"Employee: {empl.Name}, Salary: {empl.Wage()}, Department: {empl.Department}, Employed on: {empl.DateOfEmployment}");
            }
        }

        public float CalculateAvgSalary()
        {
            float sum = 0;
            foreach(Employee empl in employees)
            {
                sum += empl.Wage();
            }
            return sum / employees.Count;

        }


    }
}
