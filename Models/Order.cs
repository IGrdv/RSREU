namespace PizzaDelivery.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int ClientId { get; set; }

        public int AddressId { get; set; }

        public DateTime Date { get; set; }

        public int ChefEmployeeId { get; set; }

        public int CourierEmployeeId { get; set; }

        public int OperatorEmployeeId { get; set; }

        public int RestaurantId { get; set; }

        public string Status { get; set; }

    }
