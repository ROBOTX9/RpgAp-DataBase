using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false),
                    PersonagemHabilidadeHabilidadeId = table.Column<int>(type: "int", nullable: true),
                    PersonagemHabilidadePersonagemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_HABILIDADES_PersonagemHabilidadePersonagemId_PersonagemHabilidadeHabilidadeId",
                        columns: x => new { x.PersonagemHabilidadePersonagemId, x.PersonagemHabilidadeHabilidadeId },
                        principalTable: "TB_PERSONAGENS_HABILIDADES",
                        principalColumns: new[] { "PersonagemId", "HabilidadeId" });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 150, 231, 225, 92, 149, 118, 133, 40, 197, 144, 58, 217, 2, 56, 150, 204, 185, 159, 241, 85, 114, 186, 32, 195, 136, 66, 86, 183, 248, 28, 119, 168, 80, 123, 71, 46, 208, 32, 233, 108, 154, 100, 240, 232, 151, 32, 84, 91, 35, 247, 31, 65, 162, 142, 227, 161, 19, 130, 149, 216, 197, 221, 164, 89 }, new byte[] { 77, 27, 233, 224, 213, 184, 193, 216, 89, 224, 69, 86, 11, 124, 201, 150, 187, 109, 163, 90, 232, 223, 135, 31, 170, 61, 95, 12, 57, 210, 0, 67, 93, 84, 10, 52, 64, 154, 118, 121, 36, 178, 198, 108, 164, 157, 230, 11, 190, 163, 100, 137, 239, 54, 24, 13, 195, 13, 108, 47, 132, 201, 189, 109, 89, 74, 89, 165, 162, 61, 139, 14, 47, 82, 163, 87, 2, 78, 95, 70, 50, 14, 13, 242, 244, 37, 99, 67, 250, 81, 200, 95, 216, 46, 211, 80, 105, 201, 161, 213, 38, 22, 218, 235, 13, 181, 53, 100, 231, 73, 5, 193, 245, 144, 171, 134, 180, 182, 52, 72, 118, 109, 195, 185, 140, 94, 174, 148 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId", "PersonagemHabilidadeHabilidadeId", "PersonagemHabilidadePersonagemId" },
                values: new object[,]
                {
                    { 1, 1, null, null },
                    { 2, 1, null, null },
                    { 2, 2, null, null },
                    { 2, 3, null, null },
                    { 3, 3, null, null },
                    { 3, 4, null, null },
                    { 1, 5, null, null },
                    { 2, 6, null, null },
                    { 3, 7, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_PersonagemHabilidadePersonagemId_PersonagemHabilidadeHabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "PersonagemHabilidadePersonagemId", "PersonagemHabilidadeHabilidadeId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 65, 176, 195, 151, 51, 70, 17, 85, 195, 9, 217, 216, 74, 229, 41, 95, 29, 187, 6, 207, 41, 232, 90, 248, 163, 229, 82, 8, 103, 245, 174, 206, 139, 25, 94, 63, 50, 133, 5, 93, 124, 193, 62, 84, 120, 114, 135, 118, 212, 87, 206, 246, 73, 206, 131, 197, 111, 64, 85, 10, 182, 126, 186, 174 }, new byte[] { 235, 235, 191, 109, 28, 134, 100, 133, 128, 110, 35, 191, 147, 150, 197, 94, 29, 238, 60, 158, 28, 218, 18, 120, 90, 189, 16, 191, 5, 86, 242, 5, 162, 72, 3, 144, 2, 202, 118, 15, 93, 119, 188, 78, 248, 137, 149, 37, 36, 82, 30, 134, 156, 245, 34, 239, 175, 153, 210, 32, 149, 60, 39, 49, 221, 0, 221, 63, 168, 18, 19, 218, 178, 140, 23, 169, 13, 207, 163, 214, 230, 154, 50, 178, 250, 1, 195, 56, 72, 12, 220, 179, 41, 220, 213, 248, 255, 242, 185, 29, 241, 217, 48, 112, 139, 29, 161, 240, 24, 65, 179, 91, 220, 52, 91, 64, 103, 30, 156, 66, 46, 151, 116, 138, 157, 160, 220, 155 } });
        }
    }
}
