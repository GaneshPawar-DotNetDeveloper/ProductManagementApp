using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProductManagementApp.Models
{

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required, MaxLength(256)]
        public string? Name { get; set; }

        [Required, MaxLength(6)]
        public string? SKU { get; set; } // This will be generated automatically

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required]
        public decimal BasePrice { get; set; }

        [Required]
        public decimal MRP { get; set; }

        [NotMapped]
        public decimal Profit => MRP - BasePrice;

        public string? Description { get; set; }

        [Required]
        public Currency Currency { get; set; }

        public DateTime ManufacturedDate { get; set; } = DateTime.Today;

        [Required]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "Expire Date must be a future date.")]
        public DateTime ExpireDate { get; set; }
    }

    public enum Currency
    {
        USD,
        EUR,
        INR
        // Add other currencies as needed
    }
}