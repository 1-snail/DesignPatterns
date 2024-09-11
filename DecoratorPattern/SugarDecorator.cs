using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class SugarDecorator : CoffeeDecorator
    {
        
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
            this._coffee = coffee;
        }


        public override double GetCost()
        {
            return _coffee.GetCost() + 1;
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + " + 糖";
        }

    }
}
