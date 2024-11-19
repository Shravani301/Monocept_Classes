using System.ComponentModel.DataAnnotations;

namespace EmployeeWithGuid.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3,
        ErrorMessage = "Name must be fewer than 25 characters and " +
            "greater than 3 characters..")]
        public string Name { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

    }
}
