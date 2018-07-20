using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSort
{
    class Program
    {
        static void Main(string[] args)
        {

            Car[] myAutos = new Car[5]
            {
                new Car {Id=1, Manufacturer="Dacia", Speed=150 },
                new Car {Id=234, Manufacturer="Ford", Speed=170 },
                new Car {Id=34, Manufacturer="BMW", Speed=220 },
                new Car {Id=45, Manufacturer="Audi", Speed=200 },
                new Car {Id=5, Manufacturer="Mazda", Speed=180 }
            };

            Console.WriteLine("Initial set of cars");
            foreach (Car c in myAutos)
                Console.WriteLine(c);

            Array.Sort(myAutos);

            Array.Sort(myAutos, Car.SortBySpeed);

            Console.WriteLine("Sorted set of cars by speed");
            foreach (Car c in myAutos)
                Console.WriteLine(c);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
