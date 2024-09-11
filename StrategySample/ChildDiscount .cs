using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySample
{
    internal class ChildDiscount : Discount
    {
        public const string NAME = "ChildDiscount";

        // 非抽象类必须实现抽象类中的抽象方法
        public override float Calculate(int money)
        {
            return money * 0.5F;
        }
    }
}
