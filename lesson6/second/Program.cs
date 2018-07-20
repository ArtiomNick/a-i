using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, line, column;
            Console.WriteLine("Lenght of array: ");
            n = int.Parse(Console.ReadLine());

            int[,] second;
            second = InstantiateArray(ref n);

            Console.WriteLine("Line nr: ");
            line = int.Parse(Console.ReadLine());
            Console.WriteLine("Column nr: ");
            column = int.Parse(Console.ReadLine());
            second = CheckAndDelete(second, line, column, n);

            for (int i = 0; i < second.GetLength(0); i++)
            {
                for(int j = 0; j < second.GetLength(1); j++)
                {
                    Console.Write("{0}  ", second[i, j]);

                }
                Console.WriteLine();

            }


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        static int[,] InstantiateArray(ref int n)
        {
            int[,] second = new int[n, n];
            Console.WriteLine("Elements: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Line {0}:  ", i + 1);
                for (int j = 0; j < n; j++)
                {
                    second[i, j] = int.Parse(Console.ReadLine());
                }

            }
            return second;
        }

        static int[,] CheckAndDelete(int[,] second, int line, int column, int n)
        {
            int m = second.GetLength(0);
            bool check = true;
            for (int i = 0; i < n; i++)
            {

                if (second[line, i] != second[i, column])
                {
                    check = false;
                }
            }

            if (check)
            {
                if (line < n - 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = line; j < n - 1; j++)
                        {
                            second[j, i] = second[j + 1, i];

                        }
                    }
                }
                if (column < n - 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = column; j < n - 1; j++)
                        {
                            second[i, j] = second[i, j + 1];

                        }
                    }
                }

                n--;
                int[,] temp = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        temp[i, j] = second[i, j];
                    }
                }
                second = temp; 
            }
            return second;
        }
    }
}
