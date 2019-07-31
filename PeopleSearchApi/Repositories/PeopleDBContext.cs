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

        public DbSet<Person> Persons { get; set; }

        public PeopleDBContext(DbContextOptions<PeopleDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Person>().HasData(
              new
              {
                  PersonId = Guid.NewGuid().ToString(),
                  FirstName = "Jane",
                  LastName = "Smith",
                  Address = "22 Rathole Rd"
              },
              new
              {
                  PersonId = Guid.NewGuid().ToString(),
                  FirstName = "John",
                  LastName = "Fisher",
                  Address = "44 Mill St"
              },
              new
              {
                  PersonId = Guid.NewGuid().ToString(),
                  FirstName = "Pamela",
                  LastName = "Baker",
                  Address = "111 East Ave"
              },
              new
              {
                  PersonId = Guid.NewGuid().ToString(),
                  FirstName = "Peter",
                  LastName = "Taylor",
                  Address = "555 Main St"
              }
            );
        }
    }
}
