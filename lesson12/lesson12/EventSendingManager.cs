using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12
{
    class EventSendingManager
    {

        // 2. The event itself
        public event EventHandler<NewMailEventArgs> NewMail;

        // 3. Protected, virtual method responsible for notifying registered objects of the event
        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            // Has any objects registered interest with our event? 
            NewMail?.Invoke(this, e);     // Yes, notify all the objects
        }

        // 4. Method that translates the input into the desired event
        //    This method is called when a new e-mail message arrives
        public void SimulateArrivingMsg(String from, String to, String subject, String body)
        {
            //Construct an object to hold the information to pass to the receivers of our notification
            NewMailEventArgs e = new NewMailEventArgs(from, to, subject, body);

            // Call our virtual method notifying our object that the event occurred. If no type overrides
            // this method, our object will notify all the objects that registered interest in the event
            OnNewMail(e);
        }
    }
}
