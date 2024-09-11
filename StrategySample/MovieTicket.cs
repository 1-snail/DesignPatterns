
namespace StrategySample
{
    // 客户端代码不需要变，只需要在实例化时传入不同的 name 即可
    internal class MovieTicket
    {
        private Discount _discount;
        private int _ticketMoney;

        public MovieTicket(int money)
        {
            _ticketMoney = money;
        }


        public void SetDiscount(string name)
        {
            _discount = DiscountFactory.Create(name);
        }

        public float CalculateTicketMoney()
        {
            return _discount.Calculate(_ticketMoney);
        }
    }
}
