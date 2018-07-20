using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Program
    {


        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Lenght of array: ");
            n = int.Parse(Console.ReadLine());

            int[] first;
            first = InstantiateArray(ref n);
            DeleteEven(ref first, ref n);

            for (int i = 0; i < first.Length; i++)
            {
                Console.Write("{0}  ", first[i]);
            }

            Console.ReadKey();
        }

        static void DeleteEven(ref int[] first, ref int n)
        {
            int counter = 0;
            int[] temp = new int[n];
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] %2 == 0)
                {
                    n--;
                }
                else
                {
                    temp[counter] = first[i];
                    counter++;
                }
                
            }
            //first = temp;
            first = new int[n];
            Array.Copy(temp, first, n);
        }

        static int[] InstantiateArray(ref int n)
        {
            
            int[] first = new int[n];
            Console.WriteLine("Elements: ");
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = int.Parse(Console.ReadLine());
            }
            return first;
        }
    }
}
