using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class RaisinDecorator : Decorator
    {
        public RaisinDecorator(Ingredient baseComponent)
        : base(baseComponent)
        {
            this.Name = "Raisin";
            this.Price = 11.5;
        }
    }
}
