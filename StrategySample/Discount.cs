
namespace StrategySample
{
    // 抽象方法只能在抽象类中
    internal abstract class Discount
    {
        public const string NAEM = "";

        public abstract float Calculate(int money);
    }
}
