using System;

namespace lesson5
{
    partial class Program
    {
        public class Cashier : ServiceStaff
        {
            public override void StuffPreparations()
            {
                Console.WriteLine("Prepare work station: turning on PC, preparing cash...");
            }

        }
    }
}
