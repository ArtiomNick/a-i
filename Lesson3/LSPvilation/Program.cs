using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace LSPvilation
{
    public class Mammal
    {
        int children;
        //int furrLenght;

        public virtual void GiveBirth()
        {
            Console.WriteLine("Oh it's a baby");
        }

        public virtual void GrowFurr()
        {
            Console.WriteLine("Grow");
        }

    }

    public class Dog : Mammal
    {
        public override void GiveBirth()
        {
            
            Console.WriteLine("Oh it's a puppy");
        }

        public override void GrowFurr()
        {
            Console.WriteLine("GrowFurr");
        }
    }

    public class Platypus : Mammal
    {
        public override void GiveBirth()
        {
            throw new NotImplementedException();
        }

        public override void GrowFurr()
        {
            Console.WriteLine("GrowFurr");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

    }
}
