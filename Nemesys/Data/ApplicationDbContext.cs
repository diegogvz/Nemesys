﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nemesys.Models;

namespace Nemesys.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Report> Reports { get; set; }
        public DbSet<Investigation> Investigations { get; set; }
        public DbSet<UserVote> UserVotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Report>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Report>()
                .HasOne(r => r.Investigation)
                .WithOne(i => i.Report)
                .HasForeignKey<Investigation>(i => i.ReportID);

            modelBuilder.Entity<UserVote>()
                .HasIndex(uv => new { uv.UserId, uv.ReportID })
                .IsUnique();

            SeedRoles(modelBuilder);
            SeedAdminUser(modelBuilder);
            SeedReports(modelBuilder);
        }

        private void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "1", Name = "reporter", ConcurrencyStamp = "1", NormalizedName = "REPORTER" },
                new IdentityRole() { Id = "2", Name = "investigator", ConcurrencyStamp = "2", NormalizedName = "INVESTIGATOR" }
            );
        }

        private void SeedAdminUser(ModelBuilder modelBuilder)
        {
            User adminUser = new User
            {
                Id = "1",
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                AuthorName = "Admin User"
            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "hola1234");
            modelBuilder.Entity<User>().HasData(adminUser);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "2", UserId = "1" }
            );
        }

        private void SeedReports(ModelBuilder modelBuilder)
        {
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
                    Upvotes = 5,
                    UserId = "1"
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
                    Upvotes = 10,
                    UserId = "1"
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
                    Upvotes = 7,
                    UserId = "1"
                }
            );
        }
    }
}
