using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PizzaDelivery.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public int ClientId { get; set; }

        [Required]
        public string Apartment { get; set; } = null!;

        [Required]
        public string Building { get; set; } = null!;

        [Required]
        public string Street { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string Region { get; set; } = null!;

        [Required]
        public string PostalCode { get; set; } = null!;

        [JsonIgnore]
        public Client Client { get; set; } = null!;

        [JsonIgnore]
        public List<Order>? Orders { get; set; } = new();

    }
}
