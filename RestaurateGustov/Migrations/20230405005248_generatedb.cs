using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurateGustov.Migrations
{
    /// <inheritdoc />
    public partial class generatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    DireccionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ubicacion = table.Column<string>(type: "varchar(155)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.DireccionId);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(20)", nullable: false),
                    NIT = table.Column<int>(type: "int", nullable: false),
                    PermisoFuncionamiento = table.Column<string>(type: "varchar(20)", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(155)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(20)", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "varchar(20)", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "varchar(20)", nullable: true),
                    CI = table.Column<int>(type: "int", nullable: false),
                    Expedido = table.Column<string>(type: "varchar(5)", nullable: false),
                    TipoSangre = table.Column<string>(type: "varchar(5)", nullable: true),
                    Nacionalidad = table.Column<string>(type: "varchar(20)", nullable: false),
                    DireccionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.PersonaId);
                    table.ForeignKey(
                        name: "FK_Persona_Direccion_DireccionId",
                        column: x => x.DireccionId,
                        principalTable: "Direccion",
                        principalColumn: "DireccionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<string>(type: "varchar(20)", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_Empleado_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleado_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Solicitud",
                columns: table => new
                {
                    SolicitudId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Razon = table.Column<string>(type: "varchar(155)", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime", nullable: false),
                    Confirmacion = table.Column<bool>(type: "bit", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitud", x => x.SolicitudId);
                    table.ForeignKey(
                        name: "FK_Solicitud_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacacion",
                columns: table => new
                {
                    VacacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime", nullable: false),
                    SolicitudId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacacion", x => x.VacacionId);
                    table.ForeignKey(
                        name: "FK_Vacacion_Solicitud_SolicitudId",
                        column: x => x.SolicitudId,
                        principalTable: "Solicitud",
                        principalColumn: "SolicitudId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recibo",
                columns: table => new
                {
                    ReciboId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaEmision = table.Column<DateTime>(type: "datetime", nullable: false),
                    VacacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibo", x => x.ReciboId);
                    table.ForeignKey(
                        name: "FK_Recibo_Vacacion_VacacionId",
                        column: x => x.VacacionId,
                        principalTable: "Vacacion",
                        principalColumn: "VacacionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_PersonaId",
                table: "Empleado",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_RestaurantId",
                table: "Empleado",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_DireccionId",
                table: "Persona",
                column: "DireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Recibo_VacacionId",
                table: "Recibo",
                column: "VacacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_EmpleadoId",
                table: "Solicitud",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacacion_SolicitudId",
                table: "Vacacion",
                column: "SolicitudId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recibo");

            migrationBuilder.DropTable(
                name: "Vacacion");

            migrationBuilder.DropTable(
                name: "Solicitud");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "Direccion");
        }
    }
}
