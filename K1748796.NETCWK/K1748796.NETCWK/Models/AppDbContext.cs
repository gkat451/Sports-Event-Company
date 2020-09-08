using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K1748796.NETCWK.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base (options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Event> Events { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    id = 1,
                    Name = "Homer Simpson",
                    Address = "44 Evergreen Terrace",
                    Postcode = "TSGKDSF",
                    Phone = 001323435,
                    Email = "Homer@aol.com",
                    Gender ="Male",
                    Skills=Skills.Low,
                    Biography ="There are cardio issues"

                },
                new User
                {
                    id = 2,
                    Name = "Marge Simpson",
                    Address = "44 Evergreen Terrace",
                    Postcode = "TSGKDSF",
                    Phone = 1234214,
                    Email = "Marge@aol.com",
                    Gender = "Female",
                    Skills = Skills.High,
                    Biography = "Great at Tackling"

                },
                new User
                {
                    id = 3,
                    Name = "Moe",
                    Address = "88 Evergreen Terrace",
                    Postcode = "GSDFJGKJ",
                    Phone = 14654232,
                    Email = "Moe@aol.com",
                    Gender = "Male",
                    Skills = Skills.Medium,
                    Biography = "Drinking Problem"

                },
                new User
                {
                    id = 4,
                    Name = "Barney",
                    Address = "22 Evergreen Terrace",
                    Postcode = "TSGKDSF",
                    Phone = 001323435,
                    Email = "Barney@aol.com",
                    Gender = "Male",
                    Skills = Skills.Low,
                    Biography = "Good at shooting"

                },
                new User
                {
                    id = 5,
                    Name = "Sideshow Bob",
                    Address = "Springfiled Prison",
                    Postcode = "TSGDSJS",
                    Phone = 0013443,
                    Email = "Bob@aol.com",
                    Gender = "Male",
                    Skills = Skills.High,
                    Biography = "Great Thinker"

                }

                );
        }
       
       

        }



    }

