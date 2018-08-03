using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Decorator : Ingredient
    {
        Ingredient BaseComponent = null;

        protected string Name = "Undefined Decorator";
        protected double Price = 0.0;

        protected Decorator(Ingredient baseComponent)
        {
            BaseComponent = baseComponent;
        }



        public override string GetName()
        {
            return string.Format("{0}, {1}", BaseComponent.GetName(), Name);
        }

        public override double GetPrice()
        {
            return Price + BaseComponent.GetPrice();
        }

    }
}
