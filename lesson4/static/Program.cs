using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace @static
{
    class Program
    {
        public class Thing
        {
            public int age;
            public static string name;
            public static string color;

            public static void changeColor(string col)
            {
                color = col;
                Console.WriteLine("Changed color");

            }

            static Thing()
            {
                name = "thing";
                color = "yellow";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Thing.name + " " + Thing.color);

            Thing.color = "red";
            Console.WriteLine(Thing.color);
            Thing.changeColor("blue");
            Console.WriteLine(Thing.color);




            Thread t = new Thread(func);
            t.Start();

            Console.ReadKey();
        }

        static void func()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
