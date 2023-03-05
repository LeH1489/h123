using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace BigSchool_2.Models
{
	public class AppDbContextBigSchool : IdentityDbContext<AppUser>
    {
        public AppDbContextBigSchool(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                Name = "Development",
            },
            new Category()
            {
                Id = 2,
                Name = "Business",
            },
            new Category()
            {
                Id = 3,
                Name = "Marketing",
            }
            );


        }


        public DbSet<Course> Courses { set; get; }
        public DbSet<Category> Categories { set; get; }
    }
}

