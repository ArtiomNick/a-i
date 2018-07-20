using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Program
    {

        static void Main(string[] args)
        {
            Angle a1 = new Angle(37, 121, 52);
            Angle a2 = new Angle(12, 11, 47);
            Angle a3 = a1 + a2 + a1;
            Angle a4 = a1 - a2;
            Angle a5 = new Angle(12, 11, 47);

            if(a2 == a5)
            {
                Console.WriteLine("Equality");

            }

            Console.WriteLine(a3.ToString());
            Console.ReadKey();
        }
    }
}
