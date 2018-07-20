using System;

namespace lesson5
{
    partial class Program
    {
        public abstract class AdministartiveStaff : Employee
        {
            string specialization;
            string degree;

            public string Specialization
            {
                set { specialization = value; }
            }

            public string Degree
            {
                set { degree = value; }
            }

            public virtual void CheckEmail()
            {
                Console.WriteLine("Checking my personal email");
            }
            public virtual void CheckEmail(string client)
            {
                Console.WriteLine("Checking for " + client + " mails in my personal email");
            }
        }
    }
}
