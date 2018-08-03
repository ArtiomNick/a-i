using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12
{
    class GatheringEventManager
    {

        public event EventHandler<NewGatheringEventArgs> NewGathering;

       
        protected virtual void OnNewGathering(NewGatheringEventArgs e)
        {
            NewGathering?.Invoke(this, e);     
        }

        
        public void SimulateArrivingMsg(String name, String subject, DateTime dateTime)
        {
            NewGatheringEventArgs e = new NewGatheringEventArgs(name, subject, dateTime);

            OnNewGathering(e);
        }
    }
}
