using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_Tecnico_MVC___Web_API.Migrations
{
    public partial class CambioNomeColonna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Viaggi",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Viaggi",
                newName: "Nome");
        }
    }
}
