namespace PizzaDelivery.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public int ClientId { get; set; }

        public string Apartment { get; set; }

        public string Building { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

    }
}
