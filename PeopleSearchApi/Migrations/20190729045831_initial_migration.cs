using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleSearchApi.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Address", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "187739bd-b271-44d9-9e56-70846dee9dc8", "22 Rathole Rd", "Jane", "Smith" },
                    { "b2724d38-d38e-4416-82ff-160a0c7ac49b", "44 Mill St", "John", "Fisher" },
                    { "d301f57b-5a85-43a0-b50d-ecc48eff79a0", "111 East Ave", "Pamela", "Baker" },
                    { "75e01edf-d037-49f9-8fa2-b2208ffc6f69", "555 Main St", "Peter", "Taylor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
