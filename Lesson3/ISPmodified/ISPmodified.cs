using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPmodified
{
    public interface IWorkForCleaner
    {
        void clean();

    }

    public class Cleaner:IWorkForCleaner
    {
        public void clean()
        {
            Console.WriteLine("Cleaner cleans...");
            Console.ReadKey();
        }

        
    }

    public interface IWorkForManager
    {
        void manage();

    }

    public class Manager:IWorkForManager
    {
        public void manage()
        {
            Console.WriteLine("Manager manages...");
            Console.ReadKey();
        }
    }

    class ISPmodified
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
