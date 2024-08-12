using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgramacionAvanzada1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokedexes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Debilidad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Evoluciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokedexes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UsuarioName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradores", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Administradores_Usuarios_ID",
                        column: x => x.ID,
                        principalTable: "Usuarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enfermeros",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enfermeros", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Enfermeros_Usuarios_ID",
                        column: x => x.ID,
                        principalTable: "Usuarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entrenadores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Equipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenadores", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Entrenadores_Usuarios_ID",
                        column: x => x.ID,
                        principalTable: "Usuarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmisorID = table.Column<int>(type: "int", nullable: true),
                    ReceptorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mensajes_Entrenadores_EmisorID",
                        column: x => x.EmisorID,
                        principalTable: "Entrenadores",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Mensajes_Entrenadores_ReceptorID",
                        column: x => x.ReceptorID,
                        principalTable: "Entrenadores",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Debilidad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Evoluciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    EntrenadorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pokemons_Entrenadores_EntrenadorID",
                        column: x => x.EntrenadorID,
                        principalTable: "Entrenadores",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Retos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Resultado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntrenadorID1 = table.Column<int>(type: "int", nullable: true),
                    EntrenadorID2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Retos_Entrenadores_EntrenadorID1",
                        column: x => x.EntrenadorID1,
                        principalTable: "Entrenadores",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Retos_Entrenadores_EntrenadorID2",
                        column: x => x.EntrenadorID2,
                        principalTable: "Entrenadores",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_EmisorID",
                table: "Mensajes",
                column: "EmisorID");

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_ReceptorID",
                table: "Mensajes",
                column: "ReceptorID");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_EntrenadorID",
                table: "Pokemons",
                column: "EntrenadorID");

            migrationBuilder.CreateIndex(
                name: "IX_Retos_EntrenadorID1",
                table: "Retos",
                column: "EntrenadorID1");

            migrationBuilder.CreateIndex(
                name: "IX_Retos_EntrenadorID2",
                table: "Retos",
                column: "EntrenadorID2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "Enfermeros");

            migrationBuilder.DropTable(
                name: "Mensajes");

            migrationBuilder.DropTable(
                name: "Pokedexes");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Retos");

            migrationBuilder.DropTable(
                name: "Entrenadores");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
