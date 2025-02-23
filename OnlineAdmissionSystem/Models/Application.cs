namespace OnlineAdmissionSystem.Models
{
    public class Application
    {
        public int Id { get; set; } // Primary key

        public int StudentId { get; set; } // Foreign key for Student
        public Student Student { get; set; } // Navigation property

        public int CourseId { get; set; } // Foreign key for Course
        public Course Course { get; set; } // Navigation property

        public string Status { get; set; } = "Pending"; // Default status
    }
}