using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoDeEstudoOpensea.Migrations
{
    /// <inheritdoc />
    public partial class referenciasAutorEProprietario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AutorId",
                table: "Colecoes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProprietarioId",
                table: "Artes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Colecoes_AutorId",
                table: "Colecoes",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Artes_ProprietarioId",
                table: "Artes",
                column: "ProprietarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artes_AspNetUsers_ProprietarioId",
                table: "Artes",
                column: "ProprietarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Colecoes_AspNetUsers_AutorId",
                table: "Colecoes",
                column: "AutorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artes_AspNetUsers_ProprietarioId",
                table: "Artes");

            migrationBuilder.DropForeignKey(
                name: "FK_Colecoes_AspNetUsers_AutorId",
                table: "Colecoes");

            migrationBuilder.DropIndex(
                name: "IX_Colecoes_AutorId",
                table: "Colecoes");

            migrationBuilder.DropIndex(
                name: "IX_Artes_ProprietarioId",
                table: "Artes");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Colecoes");

            migrationBuilder.DropColumn(
                name: "ProprietarioId",
                table: "Artes");
        }
    }
}
