using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

    }
}
