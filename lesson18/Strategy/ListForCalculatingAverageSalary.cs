using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class ListForCalculatingAverageSalary
    {
        private readonly List<Employee> employees;

        private ICalculateAvgSalary calculationStrategy;

        public ListForCalculatingAverageSalary()
        {
            employees = new List<Employee>();
        }

        public void SetCalculationStrategy(ICalculateAvgSalary calculateAvgSalary)
        {
            this.calculationStrategy = calculateAvgSalary;
        }

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public double CalculateAvgSalary()
        {
            return calculationStrategy.CalculateAvgSalary(employees);
        }

        
    }
}
