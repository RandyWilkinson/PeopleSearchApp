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
                    Address = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Interests = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Address", "Age", "FirstName", "ImageUrl", "Interests", "LastName" },
                values: new object[,]
                {
                    { "1", "22 Rathole Rd Chico, CA 95928", 19, "Jane", "https://localhost:44300/api/people/pic/1", "Hockey, Running", "Smith" },
                    { "2", "44 Mill St Chico, CA 95928", 22, "Emily", "https://localhost:44300/api/people/pic/2", "Photograhy, Cycling", "Fisher" },
                    { "3", "111 East Ave Chico, CA 95928", 38, "Pamela", "https://localhost:44300/api/people/pic/3", "Bowling, Rugby", "Baker" },
                    { "4", "555 Main St Chico, CA 95928", 20, "Julie", "https://localhost:44300/api/people/pic/4", "Painting, Running", "Taylor" },
                    { "5", "555 Main St Chico, CA 95928", 22, "Bill", "https://localhost:44300/api/people/pic/5", "Hockey, Pottery", "Taylor" },
                    { "6", "67 First St Dallas, TX 95928", 22, "Peter", "https://localhost:44300/api/people/pic/6", "Baseball, Football", "Taylor" },
                    { "7", "5 3rd St Chico, CA 95928", 22, "John", "https://localhost:44300/api/people/pic/7", "Pottery, Hunting", "Smith" },
                    { "8", "22 Elm St Chico, CA 95928", 22, "Brian", "https://localhost:44300/api/people/pic/8", "Archery, Quilting", "Holden" },
                    { "9", "34 Citrus St Chico, CA 95928", 22, "Jason", "https://localhost:44300/api/people/pic/9", "Hockey, Running", "North" },
                    { "10", "78 Oak way Chico, CA 95928", 22, "Peter", "https://localhost:44300/api/people/pic/10", "Horses, Fishing", "Taylor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
