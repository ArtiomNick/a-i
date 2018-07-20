using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            string fourth = System.IO.File.ReadAllText(@"C:\Users\artiom.nichifor\Desktop\Mytext.txt");

            CheckDigit(fourth);

            
            Console.ReadKey();
        }
        
        static void CheckDigit(string fourth)
        {
            Console.WriteLine("Initial string: \n" + fourth);

            StringBuilder sb = new StringBuilder();

            char[] splitList = { ' ', ',', '.' };

            string[] stringList = fourth.Split(splitList);

            for (int i = 0; i < stringList.Length; i++)
            {
                if (stringList[i].Any(char.IsDigit))
                {
                    sb.Append(stringList[i]).Append(' ');

                }
            }

            Console.WriteLine("Words with digits: \n" + sb.ToString());
        }
    }
}
