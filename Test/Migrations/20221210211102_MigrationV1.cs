using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Migrations
{
    public partial class MigrationV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculationHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    field1 = table.Column<double>(nullable: false),
                    field2 = table.Column<double>(nullable: false),
                    operationTypeId = table.Column<int>(nullable: false),
                    result = table.Column<double>(nullable: false),
                    calcDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationHistory", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculationHistory");
        }
    }
}
