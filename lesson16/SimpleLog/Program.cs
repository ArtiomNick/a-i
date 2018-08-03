using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLog
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        public class SimpleLog
        {
            //Implements a singleton logger instance
            private static  SimpleLog instance = new SimpleLog();

            //Retrieve the execution directory. Note that this is whereever this process was launched
            public String logname = "simplelog";
            protected String env = System.getProperty("user.dir");
            private static File logFile;

            public static SimpleLog getInstance()
            {
                return instance;
            }

        }
}


