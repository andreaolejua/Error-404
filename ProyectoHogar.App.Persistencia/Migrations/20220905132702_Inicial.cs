using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoHogar.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hogares",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hogares", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PatronesCrecimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatronesCrecimiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    especialidad = table.Column<int>(type: "int", nullable: true),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorasLaborales = table.Column<int>(type: "int", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    familiarId = table.Column<int>(type: "int", nullable: true),
                    NutricionistaId = table.Column<int>(type: "int", nullable: true),
                    PediatraId = table.Column<int>(type: "int", nullable: true),
                    patronCrecimientoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_PatronesCrecimiento_patronCrecimientoId",
                        column: x => x.patronCrecimientoId,
                        principalTable: "PatronesCrecimiento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personas_Personas_familiarId",
                        column: x => x.familiarId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personas_Personas_NutricionistaId",
                        column: x => x.NutricionistaId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personas_Personas_PediatraId",
                        column: x => x.PediatraId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SugerenciasCuidados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatronCrecimientoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SugerenciasCuidados", x => x.id);
                    table.ForeignKey(
                        name: "FK_SugerenciasCuidados_PatronesCrecimiento_PatronCrecimientoId",
                        column: x => x.PatronCrecimientoId,
                        principalTable: "PatronesCrecimiento",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_familiarId",
                table: "Personas",
                column: "familiarId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_NutricionistaId",
                table: "Personas",
                column: "NutricionistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_patronCrecimientoId",
                table: "Personas",
                column: "patronCrecimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_PediatraId",
                table: "Personas",
                column: "PediatraId");

            migrationBuilder.CreateIndex(
                name: "IX_SugerenciasCuidados_PatronCrecimientoId",
                table: "SugerenciasCuidados",
                column: "PatronCrecimientoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hogares");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "SugerenciasCuidados");

            migrationBuilder.DropTable(
                name: "PatronesCrecimiento");
        }
    }
}
