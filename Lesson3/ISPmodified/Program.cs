using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPmodified
{
    public interface WorkForCleaner
    {
        void clean();

    }

    public class Cleaner:WorkForCleaner
    {
        public void clean()
        {
            Console.WriteLine("Cleaner cleans...");
            Console.ReadKey();
        }

        
    }

    public interface WorkForManager
    {
        void manage();

    }

    public class Manager:WorkForManager
    {
        public void manage()
        {
            Console.WriteLine("Manager manages...");
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
