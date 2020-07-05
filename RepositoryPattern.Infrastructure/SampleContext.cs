using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Infrastructure.Models;
using System;

namespace RepositoryPattern.Infrastructure
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options) 
            : base(options)
        { 
        }

        public DbSet<Customer> Cutomers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasData(
                new Customer()
                {
                    Id = Guid.NewGuid(),
                    Name = "Test Name",
                    Surname = "Test Surname",
                    Age = 30
                });

            modelBuilder.Entity<Customer>()
                .HasData(
                new Customer()
                {
                    Id = Guid.NewGuid(),
                    Name = "Test Name 2",
                    Surname = "Test Surname 2",
                    Age = 40
                });

            base.OnModelCreating(modelBuilder);
        }
    }   
}
