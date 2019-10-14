using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace chefs_and_dishes.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "Chefs",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DOB",
                table: "Chefs",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
