using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\artiom.nichifor\Desktop\CheckMyTime.txt";
            using (FileStream fs = File.OpenRead(path))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    string s = reader.ReadToEnd();
                    //DateTime dt = Convert.ToDateTime(s);
                    DateTime dt = DateTime.Parse(s);
                    dt = dt.ToLocalTime();
                    Console.WriteLine(dt);
                }
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
