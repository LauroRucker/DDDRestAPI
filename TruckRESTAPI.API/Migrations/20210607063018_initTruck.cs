using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TruckRESTAPI.API.Migrations
{
    public partial class initTruck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    TModel = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    YearFab = table.Column<int>(nullable: false),
                    YearModel = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.TModel);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trucks");
        }
    }
}
