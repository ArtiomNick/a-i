using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace lesson8
{
    class Program
    {
        
        static void Main()
        {
            double a = 98, b = 0;
            double result = 0;
            var myList = new List<int>() { 1, 2, 3, 4, 5 };


            var angle1 = new Angle(10, 40, 82);

            //Create methods which checks input Arguments and throws exceptions
            Debug.WriteLine("Create methods which checks input Arguments and throws exceptions");
            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Attempted divide by zero.");
            }
            

            //Create custom exceptions and throw them 
            Debug.WriteLine("Create custom exceptions and throw them ");
            try
            {
                //Console.WriteLine(angle1.Seconds);
                if (angle1.Seconds > 59 || angle1.Minutes > 59)
                {
                    Console.WriteLine("");
                    throw new Exception("Too many seconds or minutes");
                }
            }
            catch(Exception) when (angle1.Seconds > 59)
            {
                Console.WriteLine("Degrees > 59");
            }
            catch (Exception) when (angle1.Minutes > 59)
            {
                Console.WriteLine("Minutes > 59");
            }

            /*
            Console.WriteLine("Need an int:");
            string s = Console.ReadLine();
            //Write Try-catch-Finally block with multiple catch statements
            try
            {
                Int32.Parse(s);
                Console.WriteLine("Number is int");
            }
            catch (FormatException)
            {
                Console.WriteLine("Number is not int");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is too big");
            }
            finally
            {
                if(s.GetType().Equals(typeof(string)))
                {
                    s = null;
                }
            }
            */

            Console.WriteLine("Need a word:");
            string s = Console.ReadLine();
            char c = GetFirstChar(s);
            

            Console.ReadKey();

        }

        static double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }

        static char GetFirstChar(string s)
        {
            try
            {
                return NewMethod(s);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("No char");
                return 'a';
            }
            finally
            {
                Console.WriteLine("finally");

            }
        }

        private static char NewMethod(string s)
        {
            return s[0];
        }
    }
}
