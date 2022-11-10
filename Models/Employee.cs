namespace PizzaDelivery.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FIO { get; set; }

        public int PositionId { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime Birthday { get; set; }

        public int RestaurantId { get; set; }

    }
}
