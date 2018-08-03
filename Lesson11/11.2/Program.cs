using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2
{
    class Program
    {
        static void Main()
        {
            Action action = CreateAction();
            action();
            action();
            action();
            Console.ReadLine();
        }

        static Action CreateAction()
        {
            int counter = 0;
            return delegate
            {
                
                counter++;
                Console.WriteLine("counter={0}", counter);
                
            };
        }
    }
}
