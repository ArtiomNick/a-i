using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Cleaner.AvgSalary = 8;
            Cleaner c = new Cleaner("name", 8, "12:00", "none");
            c.Department = "groceries";
            Console.WriteLine(c.Salary);
            Console.WriteLine(c.Name);
            Console.WriteLine(c.Department);
            c.StuffPreparations();
            c.Rest();
            Console.ReadLine();

        }
    }
}
