using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ProductManagementApp.Models
{
   

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string? CategoryName { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Product>?  Products { get; set; }
    }

}
