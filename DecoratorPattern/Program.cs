namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 生成一杯普通牛奶
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.GetDescription()} ,费用为： {coffee.GetCost()}");
            
            // 为普通咖啡添加牛奶
            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} ,费用为： {coffee.GetCost()}");

            // 为普通牛奶加糖
            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} ,费用为： {coffee.GetCost()}");

        }
    }
}
