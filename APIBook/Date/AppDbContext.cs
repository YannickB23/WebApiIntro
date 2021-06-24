using APIBook.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace APIBook.Date
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book() { Id = 1, Title = "Harry Potter", Author = "JK Rowling", Genre = "Fantasy", Description = "Fun book to read", DateRead = DateTime.Now, Rate = 7 },
                new Book() { Id = 2, Title = ".Net Core", Author = "John Doe", Genre = "ICT", Description = "Learning .net development", DateRead = DateTime.Now, Rate = 6 },
                new Book() { Id = 3, Title = "IT", Author = "Stephen King", Genre = "Horror", Description = "Shit your pants reading", DateRead = DateTime.Now, Rate = 9 }
                );
        }
    }
}
