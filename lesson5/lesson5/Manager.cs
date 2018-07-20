using System;

namespace lesson5
{
    partial class Program
    {
        public class Manager : AdministartiveStaff
        {
            public override void CheckEmail()
            {
                Console.WriteLine("Checking administrative email");
            }
            public override void CheckEmail(string client)
            {
                base.CheckEmail(client);
                Console.WriteLine("Checking for " + client + " mails in administrative email");
            }
        }
    }
}
