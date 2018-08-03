using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12
{
    class Program
    {
        static void Main(string[] args)
        {

            GatheringEventManager gem = new GatheringEventManager();

            AdministrativeEmployee administrative = new AdministrativeEmployee(gem);
            ServiceEmployee service = new ServiceEmployee(gem);

            gem.SimulateArrivingMsg("Ana's birthday", "Need to celebrate", new DateTime(2018, 8, 15, 8, 30, 0));
            

            service.Unregister(gem);
            gem.SimulateArrivingMsg("Office workers feast", "Need to party", new DateTime(2018, 8, 17, 17, 30, 0));



            Console.WriteLine("Hello World!");
            Console.ReadKey();
            
        }
    }
}
