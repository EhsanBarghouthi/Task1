using Microsoft.EntityFrameworkCore;
using RelationsTask1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsTask1.Data
{
    internal class ApplicationContextDb :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=ASP11_MVC3;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create 2 Users : 
            modelBuilder.Entity<User>().HasData(
           new User
           {
               UserId = 1,
                UserName ="User1",
                Email ="User1@gmial.com",
                Password ="Password1"
           },
           new User
           {
               UserId = 2,
               UserName = "User2",
               Email = "User2@gmial.com",
               Password = "Password2"
           });


        // Creatre 5 Blogs : 
           modelBuilder.Entity<Blog>().HasData(
            new Blog
            {
                BlogId = 1,
                BlogTitle="Task1",
                BlogDescription="The Task1 Description",
                UserId=1,
            },
                        new Blog
                        {
                            BlogId = 2,
                BlogTitle="Task2",
                BlogDescription="The Task2 Description",
                UserId=1,
            },
                                    new Blog

                                    {
                                        BlogId = 3,
                BlogTitle="Task3",
                BlogDescription="The Task3 Description",
                UserId=1,
            },
                                    new Blog
                                    {
                BlogId = 4,
                BlogTitle="Task4",
                BlogDescription="The Task4 Description",
                UserId=2,
            },
                                    new Blog
                                    {
                BlogId = 5,
                BlogTitle="Task5",
                BlogDescription="The Task5 Description",
                UserId=2,
            }
            
            );
        }
    }
}



