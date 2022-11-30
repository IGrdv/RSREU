using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PizzaDelivery.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FIO { get; set; } = null!;

        public int PositionId { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; } = null!;

        public DateTime Birthday { get; set; }

        public int RestaurantId { get; set; }

        [JsonIgnore]
        public Position? Position { get; set; }

    }
}
