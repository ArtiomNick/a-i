using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPviolation
{
    public class Animal
    {
    }

    public class Dog : Animal
    {
    } 

    public class Cat : Animal
    {
    }


    class OCPviolation
    {
        public void Bark(Animal d)
        {
            Console.WriteLine("Bark!");
        }

        public void Meow(Animal c)
        {
            Console.WriteLine("Meow!");

        }

        public void DoNoise(Animal a)
        {
            if (a.GetType() == typeof(Dog))
            {
                Bark(a);
            }
            else if (a.GetType() == typeof(Cat))
            {
                Meow(a);
            }
           

            
        }

        static void Main(string[] args)
        {
            OCPviolation ocp = new OCPviolation();
            Dog dog = new Dog();
            Cat cat = new Cat();

            ocp.DoNoise(dog);
            ocp.DoNoise(cat);

            Console.ReadKey();
        }
    }
}
