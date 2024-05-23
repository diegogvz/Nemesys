using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nemesys.Models;

namespace Nemesys.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Inserciones de datos de ejemplo
            modelBuilder.Entity<Report>().HasData(
                new Report
                {
                    ReportID = 1,
                    DateOfReport = DateTime.Now,
                    Title = "Report 1",
                    Location = "Building A",
                    HazardDateTime = DateTime.Now.AddDays(-3),
                    HazardType = "Unsafe Act",
                    Description = "Content of Report 1",
                    Status = "Open",
                    ImageUrl = "C:\\Users\\34722\\Pictures\\501_maradona.jpg",
                    Upvotes = 5
                },
                new Report
                {
                    ReportID = 2,
                    DateOfReport = DateTime.Now.AddDays(-1),
                    Title = "Report 2",
                    Location = "Building B",
                    HazardDateTime = DateTime.Now.AddDays(-4),
                    HazardType = "Unsafe Condition",
                    Description = "Content of Report 2",
                    Status = "Closed",
                    ImageUrl = "C:\\Users\\34722\\Pictures\\501_maradona.jpg",
                    Upvotes = 10
                },
                new Report
                {
                    ReportID = 3,
                    DateOfReport = DateTime.Now.AddDays(-2),
                    Title = "Report 3",
                    Location = "Building C",
                    HazardDateTime = DateTime.Now.AddDays(-5),
                    HazardType = "Unsafe Equipment",
                    Description = "Content of Report 3",
                    Status = "In Progress",
                    ImageUrl = "C:\\Users\\34722\\Pictures\\501_maradona.jpg",
                    Upvotes = 7
                }
            );
        }
    }
}



