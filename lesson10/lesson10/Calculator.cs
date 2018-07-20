using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10
{
    public delegate object SalaryCalculations(object a, object b);

    class Calculator
    {
        public static object Add_Int(object a, object b)
        {
            return (int)a + (int)b;
        }

        public static object Add_String(object a, object b)
        {
            return (string)a + (string)b;
        }

        public static object Add_EmployeeSalary(object a, object b)
        {
            return Add_Int(((Employee)a).Salary, ((Employee)b).Salary);
        }


        public static object Calculate(object initialValue, object modifyingValue, SalaryCalculations calculations)
        {
            return calculations(initialValue, modifyingValue);
        }

        public static object CalculateWithLambdaExpresion(object initialValue, object modifyingValue, Func<object, object, object> calculations)
        {
            return calculations(initialValue, modifyingValue);
        }

    }
}
