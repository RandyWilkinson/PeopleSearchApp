using Microsoft.EntityFrameworkCore;
using PeopleSearchApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleSearchApi.Repositories
{
    public class PeopleDBContext : DbContext, IPeopleRepository
    {
        private readonly string imagePath = @"https://localhost:44300/api/people/pic/";

        public DbSet<Person> Persons { get; set; }

        public PeopleDBContext(DbContextOptions<PeopleDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Person>().HasData(
              new
              {
                  PersonId = "1",//Guid.NewGuid().ToString(),
                  FirstName = "Jane",
                  LastName = "Smith",
                  Address = "22 Rathole Rd Chico, CA 95928",
                  Age = 19,
                  Interests = "Hockey, Running",
                  ImageUrl = imagePath + "1"
              },
              new
              {
                  PersonId = "2", //Guid.NewGuid().ToString(),
                  FirstName = "Emily",
                  LastName = "Fisher",
                  Address = "44 Mill St Chico, CA 95928",
                  Age = 22,
                  Interests = "Photograhy, Cycling",
                  ImageUrl = imagePath + "2"
              },
              new
              {
                  PersonId = "3",//Guid.NewGuid().ToString(),
                  FirstName = "Pamela",
                  LastName = "Baker",
                  Address = "111 East Ave Chico, CA 95928",
                  Age = 38,
                  Interests = "Bowling, Rugby",
                  ImageUrl = imagePath + "3"
              },
              new
              {
                  PersonId = "4",//Guid.NewGuid().ToString(),
                  FirstName = "Julie",
                  LastName = "Taylor",
                  Address = "555 Main St Chico, CA 95928",
                  Age = 20,
                  Interests = "Painting, Running",
                  ImageUrl = imagePath + "4"
              },
              new
              {
                  PersonId = "5",//Guid.NewGuid().ToString(),
                  FirstName = "Bill",
                  LastName = "Taylor",
                  Address = "555 Main St Chico, CA 95928",
                  Age = 22,
                  Interests = "Hockey, Pottery",
                  ImageUrl = imagePath + "5"
              },
              new
              {
                  PersonId = "6",//Guid.NewGuid().ToString(),
                  FirstName = "Peter",
                  LastName = "Taylor",
                  Address = "67 First St Dallas, TX 95928",
                  Age = 22,
                  Interests = "Baseball, Football",
                  ImageUrl = imagePath + "6"
              },
              new
              {
                  PersonId = "7",//Guid.NewGuid().ToString(),
                  FirstName = "John",
                  LastName = "Smith",
                  Address = "5 3rd St Chico, CA 95928",
                  Age = 22,
                  Interests = "Pottery, Hunting",
                  ImageUrl = imagePath + "7"
              },
              new
              {
                  PersonId = "8",//Guid.NewGuid().ToString(),
                  FirstName = "Brian",
                  LastName = "Holden",
                  Address = "22 Elm St Chico, CA 95928",
                  Age = 22,
                  Interests = "Archery, Quilting",
                  ImageUrl = imagePath + "8"
              },
              new
              {
                  PersonId = "9",//Guid.NewGuid().ToString(),
                  FirstName = "Jason",
                  LastName = "North",
                  Address = "34 Citrus St Chico, CA 95928",
                  Age = 22,
                  Interests = "Hockey, Running",
                  ImageUrl = imagePath + "9"
              },
              new
              {
                  PersonId = "10",//Guid.NewGuid().ToString(),
                  FirstName = "Peter",
                  LastName = "Taylor",
                  Address = "78 Oak way Chico, CA 95928",
                  Age = 22,
                  Interests = "Horses, Fishing",
                  ImageUrl = imagePath + "10"
              }
            );
        }
    }
}
