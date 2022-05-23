using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_Tecnico_MVC___Web_API.Migrations
{
    public partial class CambioNomeColonne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prezzo",
                table: "Viaggi",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Durata",
                table: "Viaggi",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "Destinazione",
                table: "Viaggi",
                newName: "Destination");

            migrationBuilder.RenameColumn(
                name: "Descrizione",
                table: "Viaggi",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Viaggi",
                newName: "Prezzo");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Viaggi",
                newName: "Durata");

            migrationBuilder.RenameColumn(
                name: "Destination",
                table: "Viaggi",
                newName: "Destinazione");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Viaggi",
                newName: "Descrizione");
        }
    }
}
