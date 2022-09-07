using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.App.Persistencia.Migrations
{
    public partial class Inactivacon_Borrado_Cascada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioId",
                table: "Reservas");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioId",
                table: "Reservas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioId",
                table: "Reservas");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioId",
                table: "Reservas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
