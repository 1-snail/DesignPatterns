using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return _coffee.GetCost();
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + "+ 牛奶";
        }

    }
}
