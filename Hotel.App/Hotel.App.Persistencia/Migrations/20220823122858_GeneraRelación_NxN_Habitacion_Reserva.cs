using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel.App.Persistencia.Migrations
{
    public partial class GeneraRelación_NxN_Habitacion_Reserva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habitaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    camas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservaHabitacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservaId = table.Column<int>(type: "int", nullable: false),
                    HabitacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaHabitacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservaHabitacion_Habitaciones_HabitacionId",
                        column: x => x.HabitacionId,
                        principalTable: "Habitaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservaHabitacion_Reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "Reservas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservaHabitacion_HabitacionId",
                table: "ReservaHabitacion",
                column: "HabitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaHabitacion_ReservaId",
                table: "ReservaHabitacion",
                column: "ReservaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservaHabitacion");

            migrationBuilder.DropTable(
                name: "Habitaciones");
        }
    }
}
