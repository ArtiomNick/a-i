using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modified
{
    public abstract class ProductPurchase : IProductPurchase
    {
        public abstract void buyingProduct();
        public abstract void rejectingProduct();

    }

    public abstract class ProductResearch : IProductResearch
    {
        public abstract void negotiatingThePrice();
        public abstract void studingTheProduct();

    }
    

    public class Client : IProductPurchase, IProductResearch
    {
        ProductResearch Research { get; set; }
        ProductPurchase Purchase { get; set; }

        public void buyingProduct()
        {
        }

        public void negotiatingThePrice()
        {
         
        }

        public void rejectingProduct()
        {
        }

        public void studingTheProduct()
        {
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
