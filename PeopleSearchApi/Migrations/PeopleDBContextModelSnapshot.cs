﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeopleSearchApi.Repositories;

namespace PeopleSearchApi.Migrations
{
    [DbContext(typeof(PeopleDBContext))]
    partial class PeopleDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PeopleSearchApi.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("Age");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Interests");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonId = "1",
                            Address = "22 Rathole Rd Chico, CA 95928",
                            Age = 19,
                            FirstName = "Jane",
                            ImageUrl = "https://localhost:44300/api/people/pic/1",
                            Interests = "Hockey, Running",
                            LastName = "Smith"
                        },
                        new
                        {
                            PersonId = "2",
                            Address = "44 Mill St Chico, CA 95928",
                            Age = 22,
                            FirstName = "Emily",
                            ImageUrl = "https://localhost:44300/api/people/pic/2",
                            Interests = "Photograhy, Cycling",
                            LastName = "Fisher"
                        },
                        new
                        {
                            PersonId = "3",
                            Address = "111 East Ave Chico, CA 95928",
                            Age = 38,
                            FirstName = "Pamela",
                            ImageUrl = "https://localhost:44300/api/people/pic/3",
                            Interests = "Bowling, Rugby",
                            LastName = "Baker"
                        },
                        new
                        {
                            PersonId = "4",
                            Address = "555 Main St Chico, CA 95928",
                            Age = 20,
                            FirstName = "Julie",
                            ImageUrl = "https://localhost:44300/api/people/pic/4",
                            Interests = "Painting, Running",
                            LastName = "Taylor"
                        },
                        new
                        {
                            PersonId = "5",
                            Address = "555 Main St Chico, CA 95928",
                            Age = 22,
                            FirstName = "Bill",
                            ImageUrl = "https://localhost:44300/api/people/pic/5",
                            Interests = "Hockey, Pottery",
                            LastName = "Taylor"
                        },
                        new
                        {
                            PersonId = "6",
                            Address = "67 First St Dallas, TX 95928",
                            Age = 22,
                            FirstName = "Peter",
                            ImageUrl = "https://localhost:44300/api/people/pic/6",
                            Interests = "Baseball, Football",
                            LastName = "Taylor"
                        },
                        new
                        {
                            PersonId = "7",
                            Address = "5 3rd St Chico, CA 95928",
                            Age = 22,
                            FirstName = "John",
                            ImageUrl = "https://localhost:44300/api/people/pic/7",
                            Interests = "Pottery, Hunting",
                            LastName = "Smith"
                        },
                        new
                        {
                            PersonId = "8",
                            Address = "22 Elm St Chico, CA 95928",
                            Age = 22,
                            FirstName = "Brian",
                            ImageUrl = "https://localhost:44300/api/people/pic/8",
                            Interests = "Archery, Quilting",
                            LastName = "Holden"
                        },
                        new
                        {
                            PersonId = "9",
                            Address = "34 Citrus St Chico, CA 95928",
                            Age = 22,
                            FirstName = "Jason",
                            ImageUrl = "https://localhost:44300/api/people/pic/9",
                            Interests = "Hockey, Running",
                            LastName = "North"
                        },
                        new
                        {
                            PersonId = "10",
                            Address = "78 Oak way Chico, CA 95928",
                            Age = 22,
                            FirstName = "Peter",
                            ImageUrl = "https://localhost:44300/api/people/pic/10",
                            Interests = "Horses, Fishing",
                            LastName = "Taylor"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
