using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //装饰器基类
    internal abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;
        public CoffeeDecorator(ICoffee coffee)
        {
            this._coffee = coffee;
        }
        // 以抽象的方式实现接口
        public abstract double GetCost();
        public abstract string GetDescription();

    }
}
