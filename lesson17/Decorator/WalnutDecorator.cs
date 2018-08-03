using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class WalnutDecorator : Decorator
    {
        public WalnutDecorator(Ingredient baseComponent)
        : base(baseComponent)
        {
            this.Name = "Walnut";
            this.Price = 15.5;
        }
    }
}
