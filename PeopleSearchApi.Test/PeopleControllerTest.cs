using Microsoft.EntityFrameworkCore;
using Moq;
using PeopleSearchApi.Controllers;
using PeopleSearchApi.Models;
using PeopleSearchApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Microsoft.AspNetCore.Hosting;


namespace PeopleSearchApi.Test
{
    public class PeopleDBContextTest
    {
        [Fact]
        public async void GetPersonsTest()
        {
            var options = new DbContextOptionsBuilder<PeopleDBContext>()
                .UseInMemoryDatabase(databaseName: "PeopleDB")
                .Options;

            Person[] testPersons =
                new List<Person>
                {
                    new Person { PersonId= "1", FirstName = "test", LastName= "last" },
                    new Person { PersonId= "2", FirstName = "test1", LastName= "last1" },
                    new Person { PersonId= "3", FirstName = "Found", LastName= "Never" },
                    new Person { PersonId= "4", FirstName = "first", LastName= "test" },
                    new Person { PersonId= "5", FirstName = "first1", LastName= "test1" }
                }.ToArray();

            // Setup test data in the InMemory database
            using (var context = new PeopleDBContext(options))
            {
                context.Persons.AddRange(testPersons);
                context.SaveChanges();
            }

            // mock the hosting environment
            var hostingEnv = new Mock<IHostingEnvironment>();

            // Use a clean instance of the context to run the test
            using (var context = new PeopleDBContext(options))
            {
                /* Act */
                var result = await context.FindPersonsByName("es");

                /* Assert */
                Assert.Equal(4, result.Count());

                var testResult = result.ToArray();

                // should contain all but the middle person
                Assert.Equal("1", testResult[0].PersonId);
                Assert.Equal("2", testResult[1].PersonId);
                Assert.Equal("4", testResult[2].PersonId);
                Assert.Equal("5", testResult[3].PersonId);
            }
        }
    }
}
