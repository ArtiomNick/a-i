using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public interface IWork
    {
        void clean();
        void manage();
        void sell();
    }

    public class Cleaner:IWork
    {
        public void clean()
        {
            Console.WriteLine("Cleaner cleans...");
            Console.ReadKey();
        }

        public void manage()
        {
            throw new NotImplementedException();
        }

        public void sell()
        {
            throw new NotImplementedException();
        }
    }

    public class Manager : IWork
    {
        public void clean()
        {
            throw new NotImplementedException();
        }

        public void manage()
        {
            Console.WriteLine("Manager manages...");
            Console.ReadKey();
        }

        public void sell()
        {
            throw new NotImplementedException();
        }
    }

    class ISPviolation
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
