using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18
{
    interface IObserver
    {
        void Update(Shift shift);
    }
}
