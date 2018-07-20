using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPmodified
{
    public interface IBirth
    {
        void GiveBirth();
    }

    public class Mammal
    {
        int age;
        public virtual void GrowFurr()
        {
            Console.WriteLine("Oh it's a baby");
        }

    }

    public class Dog : Mammal, IBirth
    {
        public void GiveBirth()
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
