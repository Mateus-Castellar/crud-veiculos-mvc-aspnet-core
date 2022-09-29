using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroDeVeiculosEtec.Migrations
{
    public partial class ComprimentoCampoChassi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Chassi",
                table: "Veiculos",
                type: "char(17)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Chassi",
                table: "Veiculos",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(17)");
        }
    }
}
