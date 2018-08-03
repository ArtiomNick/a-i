using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class ServiceEmployee
    {


        public void ServiceEmplMsg(Object sender, NewGatheringEventArgs e)
        {
            Console.WriteLine("Send notification about social gathering to a service employee");
            Console.WriteLine("   Name: {0}\n   Subject: {1}\n  Date: {2}\n", e.name, e.subject, e.dateTime);
        }

    }
}
