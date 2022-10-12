using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Cooperchip.ITDeveloper.Data.Migrations
{
    public partial class AddDataCadastro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Paciente",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Medicamento",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Generico",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "EstadoPaciente",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Cid",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Medicamento");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Generico");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "EstadoPaciente");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Cid");
        }
    }
}
