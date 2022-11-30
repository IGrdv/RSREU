using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PizzaDelivery.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string RestaurantAddress { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public int ActiveOrders { get; set; }
        
        [JsonIgnore]
        public List<Order> Orders { get; set; } = new();

    }
}
