using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySample
{
    internal class StudentDiscount : Discount
    {
        public const string NAME = "StudentDiscount";

        public override float Calculate(int money)
        {
            return money * 0.8f;
        }
    }
}
