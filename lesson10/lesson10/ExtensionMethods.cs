using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10
{
    public static class CalculationsForIntList
    {
        public static float CalculateAvg(this List<Employee> employees)
        {
            float avgSalary = 0;
            for(int i=0; i<employees.Count; i++)
            {
                avgSalary += employees[i].Salary;
            }

            avgSalary = avgSalary / employees.Count;

            return avgSalary;
        }

        
    }
}
