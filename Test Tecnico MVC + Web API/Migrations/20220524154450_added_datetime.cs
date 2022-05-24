using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_Tecnico_MVC___Web_API.Migrations
{
    public partial class added_datetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Messages",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Messages");
        }
    }
}
