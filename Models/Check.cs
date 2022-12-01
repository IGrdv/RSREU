using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PizzaDelivery.Models
{
    public class Check
    {
        [Key]
        public int Id { get; set; }

        public int PaymentType { get; set; }

        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public decimal CheckAmount { get; set; }

        [JsonIgnore]
        public Product? Product { get; set; }

    }
}
