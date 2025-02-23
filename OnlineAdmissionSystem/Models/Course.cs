using System.ComponentModel.DataAnnotations;

namespace OnlineAdmissionSystem.Models
{
    public class Course
    {
        public int Id { get; set; } // Primary key

        [Required]
        public string Name { get; set; }

        public int Duration { get; set; } // Duration in months

        public decimal Fees { get; set; } // Course fees
    }
}