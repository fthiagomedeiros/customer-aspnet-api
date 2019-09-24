using System.ComponentModel.DataAnnotations;

namespace CustomerService.Domain
{
    public class Customer
    {
        private const int MaxAgeValue = 90;
        private const int MinAgeValue = 13;

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Range(MinAgeValue, MaxAgeValue)]
        public int Age { get; set; }
    }
}