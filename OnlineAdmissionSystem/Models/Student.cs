using System.ComponentModel.DataAnnotations;

namespace OnlineAdmissionSystem.Models
{
    public class Student
    {
        public int Id { get; set; } // Primary key

        [Required] // Ensures the Name field is required
        public string Name { get; set; }

        [Required]
        [EmailAddress] // Validates the email format
        public string Email { get; set; }

        [Required]
        [Phone] // Validates the phone number format
        public string Phone { get; set; }
    }
}