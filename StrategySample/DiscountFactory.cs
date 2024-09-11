using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySample
{
    internal static class DiscountFactory
    {
        public static Discount Create(string name)
        {
            try
            {
                // 假设类型名称遵循 "Namespace.ClassName" 的格式
                Type type = Type.GetType($"StrategySample.{name}");
                if (type == null || !typeof(Discount).IsAssignableFrom(type))
                {
                    // 类型不存在或不是 Discount 的子类/实现
                    return null;
                }
                // 通过反射创建实例
                return Activator.CreateInstance(type) as Discount;
            }
            catch (Exception ex)
            {
                // 处理异常，例如记录日志
                // Log.Error("Error creating discount instance", ex);
                return null;
            }
        }
    }
}
