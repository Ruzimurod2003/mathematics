using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mathematics.Migrations
{
    public partial class CreateRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Birth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Login = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Birth", "Email", "Login", "Name", "Password", "Role" },
                values: new object[] { 1, new DateTime(2003, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruzimurodabdunazarov@gmail.com", "Ruzimurod03", "Ruzimurod", "P@ssvv0rd", 0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Birth", "Email", "Login", "Name", "Password", "Role" },
                values: new object[] { 2, new DateTime(1997, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "DilnerHuran@gmail.com", "Hurnur42", "Huranna", "RuzN22s", 1 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Birth", "Email", "Login", "Name", "Password", "Role" },
                values: new object[] { 3, new DateTime(2003, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Niginochka@gmail.com", "Nigi32", "Nigina", "Od4er36g", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
