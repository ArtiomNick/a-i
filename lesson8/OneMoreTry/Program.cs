using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMoreTry
{
    class Program
    {



        static void Main(string[] args)
        {
            //int[] chal = new int[5];
            //chal = InstantiateArray(chal);


            var s = Console.Read();

            A();

            //foreach (int i in chal)
            //{
            //    Console.WriteLine(i);
            //}


#if LOCAL
            GetIntInString();
#endif




            Console.ReadLine();
        }

        private static void A()
        {
            throw new NotImplementedException();
        }

        static int[] InstantiateArray(int[] chal)
        {
            try
            {
                NewMethod(chal);
            }
            catch (Exception e)
            {
                throw new Exception("", e);

                Console.WriteLine(e.ToString());



                Console.WriteLine("Number not acceptable, rewrite");

                chal = InstantiateArray(chal);



            }

            return chal;
        }

        private static void NewMethod(int[] chal)
        {
            Console.WriteLine("Elements: ");
            for (int i = 0; i < chal.Length; i++)
            {
                chal[i] = int.Parse(Console.ReadLine());
            }
        }

        static void GetIntInString()
        {
            Console.WriteLine("Need an int:");
            string s = Console.ReadLine();

            Debug.WriteLine("debug");

            Trace.WriteLine("trace");

            try
            {
                Int32.Parse(s);
                Console.WriteLine("Number is int");
            }
            catch (FormatException)
            {
                Console.WriteLine("Number is not int");
                GetIntInString();
            }
            catch (Exception e)
            {
                throw new Exception("Another exception");
            }
            finally
            {
                Console.WriteLine("finally");
                if (s.GetType().Equals(typeof(string)))
                {
                    s = null;
                }
            }
        }
    }
}
