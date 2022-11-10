namespace PizzaDelivery.Models
{
    public class Check
    {
        public int CheckNumber { get; set; }

        public int PaymentType { get; set; }

        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public decimal CheckAmount { get; set; }

    }
}
