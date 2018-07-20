using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPmodified
{
    public abstract class Animal
    {
        public abstract void doNoise();
    }

    public class Dog : Animal
    {
        public override void doNoise()
        {
            Console.WriteLine("Bark!");
        }
    }

    public class Cat : Animal
    {
        public override void doNoise()
        {
            Console.WriteLine("Meow!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            cat.doNoise();
            dog.doNoise();
            
            Console.ReadKey();
        }

        static void MyMethod(IList<Animal> animals)
        {
            foreach (var animal in animals)
            {
                animal.doNoise();
            }
        }

    }
}
