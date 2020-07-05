using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryPattern.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cutomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cutomers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cutomers",
                columns: new[] { "Id", "Age", "Name", "Surname" },
                values: new object[] { new Guid("ed3e21c6-7531-44da-b2c2-2535ba60d931"), 30, "Test Name", "Test Surname" });

            migrationBuilder.InsertData(
                table: "Cutomers",
                columns: new[] { "Id", "Age", "Name", "Surname" },
                values: new object[] { new Guid("dba15e2c-b1cf-4b5d-905c-5e4248d2d7d8"), 40, "Test Name 2", "Test Surname 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cutomers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
