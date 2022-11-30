using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PizzaDelivery.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FIO { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; } = null!;

        public DateTime Birthday { get; set; }

        [JsonIgnore]
        public List<Address>? Adresses { get; set; } = new();

    }
}
