using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class Table
    {
        [Key]
        public int TableID { get; set; }

        [Required]
        [MaxLength(100)]
        public string TableNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string TableCapacity { get; set; }

    }
}
