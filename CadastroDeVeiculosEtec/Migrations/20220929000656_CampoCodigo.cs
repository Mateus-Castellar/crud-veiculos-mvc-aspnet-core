using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroDeVeiculosEtec.Migrations
{
    public partial class CampoCodigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Veiculos",
                type: "varchar(15)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Veiculos");
        }
    }
}
