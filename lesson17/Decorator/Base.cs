using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Base : Ingredient
    {
        private string Name = "Easter Cake Base";
        private double Price = 50;

        public override string GetName()
        {
            return Name;
        }

        public override double GetPrice()
        {
            return Price;
        }
    }
}
