using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // 组件接口
    internal interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }
}
