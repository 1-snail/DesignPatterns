using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //具体组件
    internal class SimpleCoffee : ICoffee
    {
        public double GetCost()
        {
            return 5.0;
        }

        public string GetDescription()
        {
            return "简单咖啡";
        }
    }
}
