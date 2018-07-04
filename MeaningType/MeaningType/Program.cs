using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeaningType
{
    public class Product
    {
        public string name;
        public DateTime expirationDate;
        public int price;

        public void isProductOutOfDate()
        {
            Console.WriteLine("Calculating if the product is spoiled...");
            Console.ReadKey();
        }

        public void isProductExpensive()
        {
            Console.WriteLine("Calculating if the product is expensive...");
            Console.ReadKey();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.isProductOutOfDate();
            product.isProductExpensive();

        }
    }
}
