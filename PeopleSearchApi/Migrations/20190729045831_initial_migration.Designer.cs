﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeopleSearchApi;
using PeopleSearchApi.Repositories;

namespace PeopleSearchApi.Migrations
{
    [DbContext(typeof(PeopleDBContext))]
    [Migration("20190729045831_initial_migration")]
    partial class initial_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonId = "187739bd-b271-44d9-9e56-70846dee9dc8",
                            Address = "22 Rathole Rd",
                            FirstName = "Jane",
                            LastName = "Smith"
                        },
                        new
                        {
                            PersonId = "b2724d38-d38e-4416-82ff-160a0c7ac49b",
                            Address = "44 Mill St",
                            FirstName = "John",
                            LastName = "Fisher"
                        },
                        new
                        {
                            PersonId = "d301f57b-5a85-43a0-b50d-ecc48eff79a0",
                            Address = "111 East Ave",
                            FirstName = "Pamela",
                            LastName = "Baker"
                        },
                        new
                        {
                            PersonId = "75e01edf-d037-49f9-8fa2-b2208ffc6f69",
                            Address = "555 Main St",
                            FirstName = "Peter",
                            LastName = "Taylor"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
