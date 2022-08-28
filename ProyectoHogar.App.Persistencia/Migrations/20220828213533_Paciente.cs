using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoHogar.App.Persistencia.Migrations
{
    public partial class Paciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "familiarId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "patronCrecimientoId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_familiarId",
                table: "Personas",
                column: "familiarId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_patronCrecimientoId",
                table: "Personas",
                column: "patronCrecimientoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_PatronesCrecimiento_patronCrecimientoId",
                table: "Personas",
                column: "patronCrecimientoId",
                principalTable: "PatronesCrecimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_familiarId",
                table: "Personas",
                column: "familiarId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_PatronesCrecimiento_patronCrecimientoId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_familiarId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_familiarId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_patronCrecimientoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "familiarId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "patronCrecimientoId",
                table: "Personas");
        }
    }
}
