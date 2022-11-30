using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PizzaDelivery.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PositionName { get; set; } = null!;

        [JsonIgnore]
        public List<Employee>? Employees { get; set; } = new();

    }
}
