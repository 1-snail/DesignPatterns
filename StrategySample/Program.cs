using StrategySample;

internal class Program
{
    private static void Main(string[] args)
    {
        
        // 设置票价
        MovieTicket movieTicket = new MovieTicket(100);
        // 计算折扣
        movieTicket.SetDiscount("ChildDiscount");
        
        Console.WriteLine(movieTicket.CalculateTicketMoney());
    }
}