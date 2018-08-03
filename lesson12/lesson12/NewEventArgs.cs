using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12
{
    public class NewGatheringEventArgs : EventArgs
    {
         public NewGatheringEventArgs(String name, String subject, DateTime dateTime)
         {
             this.name = name;
             this.subject = subject;
             this.dateTime = dateTime;
         }
         public readonly String name, subject;
         public readonly DateTime dateTime;
    }
    
}
