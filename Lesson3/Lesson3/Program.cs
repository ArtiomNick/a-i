using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public interface Work
    {
        void clean();
        void manage();
        void sell();
    }

    public class Cleaner:Work
    {
        public void clean()
        {
            Console.WriteLine("Cleaner cleans...");
            Console.ReadKey();
        }

        public void manage()
        {
            Console.WriteLine("Cleaner manages...");
            Console.ReadKey();
        }

        public void sell()
        {
            Console.WriteLine("Cleaner sells...");
            Console.ReadKey();
        }
    }

    public class Manager : Work
    {
        public void clean()
        {
            Console.WriteLine("Manager cleans...");
            Console.ReadKey();
        }

        public void manage()
        {
            Console.WriteLine("Manager manages...");
            Console.ReadKey();
        }

        public void sell()
        {
            Console.WriteLine("Manager sells...");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cleaner cleaner = new Cleaner();
            Manager manager = new Manager();

            cleaner.clean();
            manager.manage();
        }
    }
}
