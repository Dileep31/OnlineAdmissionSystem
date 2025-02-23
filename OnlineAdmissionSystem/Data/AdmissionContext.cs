using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineAdmissionSystem.Models;

namespace OnlineAdmissionSystem.Data
{
    public class AdmissionContext : IdentityDbContext
    {
        // Constructor
        public AdmissionContext(DbContextOptions<AdmissionContext> options) : base(options) { }

        // DbSet properties for each model
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}