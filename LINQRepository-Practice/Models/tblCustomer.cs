using System.ComponentModel.DataAnnotations;

namespace LINQRepository_Practice.Models
{
    public class tblCustomer
    {
        [Key]
        public string CarRego { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CarMake { get; set; }
        public string? CarModel { get; set; }
        public string? PaymentStatus { get; set; }
    }
}
