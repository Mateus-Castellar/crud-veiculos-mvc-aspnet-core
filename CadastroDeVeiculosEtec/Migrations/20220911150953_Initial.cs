using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroDeVeiculosEtec.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Marca = table.Column<string>(type: "varchar(50)", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Fabricante = table.Column<string>(type: "varchar(50)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Combustivel = table.Column<int>(type: "int", nullable: false),
                    Cor = table.Column<string>(type: "varchar(25)", nullable: false),
                    Chassi = table.Column<string>(type: "varchar(150)", nullable: false),
                    Kilometragem = table.Column<double>(type: "float", nullable: false),
                    Revisão = table.Column<bool>(type: "bit", nullable: false),
                    Sinistro = table.Column<bool>(type: "bit", nullable: false),
                    RouboFurto = table.Column<bool>(type: "bit", nullable: false),
                    Aluguel = table.Column<bool>(type: "bit", nullable: false),
                    Venda = table.Column<bool>(type: "bit", nullable: false),
                    Particular = table.Column<bool>(type: "bit", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
