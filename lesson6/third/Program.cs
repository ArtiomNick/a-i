using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given string: ");
            string third = Console.ReadLine();

            Check(third);


            Console.ReadKey();
        }

        static void Check(string third)
        {
            Console.WriteLine("Char1: ");
            char c1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Char2: ");
            char c2 = char.Parse(Console.ReadLine());

            int count1 = 0, count2 = 0;

            for (int i = 0; i < third.Length; i++)
            {
                if (third[i] == c1)
                {
                    count1++;
                }
                else if (third[i] == c2)
                {
                    count2++;
                }
            }

            if (count1 > count2)
            {
                Console.WriteLine("Character {0} occurred more than character {1}", c1, c2);
            }
            else if (count1 == count2)
            {
                Console.WriteLine("Both characters occured {0} times", count1);
            }
            else
            {
                Console.WriteLine("Character {0} occurred less than character {1}", c1, c2);
            }
        }
    }
}
