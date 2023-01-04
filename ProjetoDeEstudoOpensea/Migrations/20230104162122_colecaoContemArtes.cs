using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjetoDeEstudoOpensea.Migrations
{
    /// <inheritdoc />
    public partial class colecaoContemArtes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "ColecaoId",
                table: "Artes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Artes_ColecaoId",
                table: "Artes",
                column: "ColecaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artes_Colecoes_ColecaoId",
                table: "Artes",
                column: "ColecaoId",
                principalTable: "Colecoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artes_Colecoes_ColecaoId",
                table: "Artes");

            migrationBuilder.DropIndex(
                name: "IX_Artes_ColecaoId",
                table: "Artes");

            migrationBuilder.DropColumn(
                name: "ColecaoId",
                table: "Artes");

            migrationBuilder.InsertData(
                table: "Artes",
                columns: new[] { "id", "nome", "preco" },
                values: new object[,]
                {
                    { 1, "Ape", null },
                    { 2, "Cripto Punk", 3500.0 },
                    { 3, "Teste", null }
                });
        }
    }
}
