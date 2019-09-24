using System.ComponentModel.DataAnnotations;

namespace CustomerService.Domain
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Name { get; set; }
        }
}