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
                    Content = "Content of Report 1",
                    ImageUrl = "C:\\Users\\34722\\Pictures\\501_maradona.jpg",
                    Upvotes = 5
                },
                new Report
                {
                    ReportID = 2,
                    DateOfReport = DateTime.Now.AddDays(-1),
                    Title = "Report 2",
                    Content = "Content of Report 2",
                    ImageUrl = "C:\\Users\\34722\\Pictures\\501_maradona.jpg",
                    Upvotes = 10
                },
                new Report
                {
                    ReportID = 3,
                    DateOfReport = DateTime.Now.AddDays(-2),
                    Title = "Report 3",
                    Content = "Content of Report 3",
                    ImageUrl = "C:\\Users\\34722\\Pictures\\501_maradona.jpg",
                    Upvotes = 7
                }
            );
        }
    }
}



