using System;

namespace lesson5
{
    partial class Program
    {
        public class Receptionist : AdministartiveStaff
        {
            public override void CheckEmail()
            {
                base.CheckEmail();
                Console.WriteLine("Checking corporative email for clients");
            }
            public override void CheckEmail(string client)
            {
                base.CheckEmail(client);
                Console.WriteLine("Checking for " + client + " mails in corporative email for clients");
            }
        }
    }
}
