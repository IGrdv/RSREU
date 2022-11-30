using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PizzaDelivery.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int AddressId { get; set; }

        public DateTime Date { get; set; }

        public int ChefEmployeeId { get; set; }

        public int CourierEmployeeId { get; set; }

        public int OperatorEmployeeId { get; set; }

        public int RestaurantId { get; set; }

        [Required]
        public string Status { get; set; }

        [JsonIgnore]
        public Client Client { get; set; }

        [JsonIgnore]
        public Address Address { get; set; }

        [JsonIgnore]
        public Employee ChefEmployee { get; set; }

        [JsonIgnore]
        public Employee CourierEmployee { get; set; }

        [JsonIgnore]
        public Employee OperatorEmployee { get; set; }

        [JsonIgnore]
        public Restaurant Restaurant { get; set; }


    }
}