using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericCollection<int> collection = new GenericCollection<int>(10);

            for(int i=0; i<10; i ++)
            {
                collection.SetItem(i * 10, i);
            }

            Console.WriteLine("Our collection: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(collection.GetItem(i) + " ");
            }

            collection.SwapItemsByIndex(2, 8);
            collection.SwapItemsByValue(-120, 600);

            Console.WriteLine("\nModified collection: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(collection.GetItem(i) + " ");
            }



            Console.ReadKey();
        }
    }
}
