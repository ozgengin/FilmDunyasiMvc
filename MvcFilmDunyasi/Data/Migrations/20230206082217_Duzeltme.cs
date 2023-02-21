using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcFilmDunyasi.Data.Migrations
{
    public partial class Duzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Puan",
                table: "Filmler",
                type: "decimal(3,1)",
                precision: 3,
                scale: 1,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,2)",
                oldPrecision: 3,
                oldScale: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Puan",
                table: "Filmler",
                type: "decimal(3,2)",
                precision: 3,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldPrecision: 3,
                oldScale: 1);
        }
    }
}
