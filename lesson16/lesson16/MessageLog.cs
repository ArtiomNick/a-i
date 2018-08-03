using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson16
{
    class MessageLog
    {
        private static readonly Lazy<MessageLog> lazy = new Lazy<MessageLog>(() => new MessageLog(), true);

        public static MessageLog Instance { get { return lazy.Value; } }


        private MessageLog()
        {

        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
