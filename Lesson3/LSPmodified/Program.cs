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

    public abstract class Mammal
    {
        int age;
        public abstract void GrowFurr();

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
