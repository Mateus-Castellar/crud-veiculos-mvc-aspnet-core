using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroDeVeiculosEtec.Migrations
{
    public partial class campoAnoString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ano",
                table: "Veiculos",
                type: "char(4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Ano",
                table: "Veiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(4)");
        }
    }
}
