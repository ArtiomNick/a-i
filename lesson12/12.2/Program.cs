using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            GatheringEventManager gem = new GatheringEventManager();

            AdministrativeEmployee administrative = new AdministrativeEmployee();
            ServiceEmployee service = new ServiceEmployee();

            gem.SimulateArrivingMsg("Ana's birthday", "Need to celebrate", new DateTime(2018, 8, 15, 8, 30, 0));

            WeakEventManager<GatheringEventManager, NewGatheringEventArgs>.AddHandler(gem, "NewGathering", administrative.AdministrativeEmplMsg);
            WeakEventManager<GatheringEventManager, NewGatheringEventArgs>.AddHandler(gem, "NewGathering", service.ServiceEmplMsg);

            gem.SimulateArrivingMsg("Ana's birthday", "Need to celebrate", new DateTime(2018, 8, 15, 8, 30, 0));

            WeakEventManager<GatheringEventManager, NewGatheringEventArgs>.RemoveHandler(gem, "NewGathering", service.ServiceEmplMsg);

            gem.SimulateArrivingMsg("Office workers feast", "Need to party", new DateTime(2018, 8, 17, 17, 30, 0));



            Console.WriteLine("Hello World!");
            Console.ReadKey();
            
        }
    }
}
