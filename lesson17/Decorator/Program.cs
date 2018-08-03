using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Base EasterCake = new Base();
            WalnutDecorator WalnutEasterCake = new WalnutDecorator(EasterCake);
            RaisinDecorator RaisinAndWalnutEasterCake = new RaisinDecorator(WalnutEasterCake);
            Console.WriteLine($"Ingridients: {RaisinAndWalnutEasterCake.GetName()};\nPrice: {RaisinAndWalnutEasterCake.GetPrice()}");
            

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
