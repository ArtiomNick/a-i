using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modified
{
    public interface ProductPurchase
    {
        void buyingProduct();
        void rejectingProduct();

    }

    public interface ProductResearch
    {
        void negotiatingThePrice();
        void studingTheProduct();

    }

    public class Client : ProductPurchase, ProductResearch
    {
        public void buyingProduct()
        {
            Console.WriteLine("Product is bought...");
            Console.ReadKey();
        }

        public void rejectingProduct()
        {
            Console.WriteLine("Product is rejected...");
            Console.ReadKey();
        }

        public void negotiatingThePrice()
        {
            Console.WriteLine("Price is going to be changed...");
            Console.ReadKey();
        }

        public void studingTheProduct()
        {
            Console.WriteLine("The product is being studied...");
            Console.ReadKey();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            client.negotiatingThePrice();
            client.buyingProduct();


        }
    }
}
