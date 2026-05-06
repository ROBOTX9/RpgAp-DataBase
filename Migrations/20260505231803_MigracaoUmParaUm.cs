using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 65, 176, 195, 151, 51, 70, 17, 85, 195, 9, 217, 216, 74, 229, 41, 95, 29, 187, 6, 207, 41, 232, 90, 248, 163, 229, 82, 8, 103, 245, 174, 206, 139, 25, 94, 63, 50, 133, 5, 93, 124, 193, 62, 84, 120, 114, 135, 118, 212, 87, 206, 246, 73, 206, 131, 197, 111, 64, 85, 10, 182, 126, 186, 174 }, new byte[] { 235, 235, 191, 109, 28, 134, 100, 133, 128, 110, 35, 191, 147, 150, 197, 94, 29, 238, 60, 158, 28, 218, 18, 120, 90, 189, 16, 191, 5, 86, 242, 5, 162, 72, 3, 144, 2, 202, 118, 15, 93, 119, 188, 78, 248, 137, 149, 37, 36, 82, 30, 134, 156, 245, 34, 239, 175, 153, 210, 32, 149, 60, 39, 49, 221, 0, 221, 63, 168, 18, 19, 218, 178, 140, 23, 169, 13, 207, 163, 214, 230, 154, 50, 178, 250, 1, 195, 56, 72, 12, 220, 179, 41, 220, 213, 248, 255, 242, 185, 29, 241, 217, 48, 112, 139, 29, 161, 240, 24, 65, 179, 91, 220, 52, 91, 64, 103, 30, 156, 66, 46, 151, 116, 138, 157, 160, 220, 155 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 117, 41, 241, 237, 47, 108, 212, 14, 250, 98, 126, 100, 178, 122, 211, 254, 97, 170, 161, 62, 61, 49, 83, 1, 32, 249, 122, 24, 100, 90, 22, 222, 189, 172, 18, 158, 140, 88, 209, 236, 1, 97, 231, 85, 11, 63, 5, 227, 142, 159, 61, 47, 62, 5, 155, 85, 97, 105, 198, 185, 245, 171, 20, 186 }, new byte[] { 252, 134, 242, 199, 119, 206, 59, 249, 7, 88, 36, 106, 71, 247, 132, 250, 37, 133, 148, 208, 93, 179, 33, 54, 7, 56, 216, 123, 206, 146, 98, 151, 124, 241, 165, 100, 186, 75, 25, 138, 171, 183, 137, 98, 199, 155, 83, 223, 136, 199, 173, 79, 69, 134, 162, 96, 3, 74, 206, 228, 50, 195, 26, 242, 254, 104, 81, 115, 48, 171, 157, 233, 232, 181, 97, 185, 91, 130, 83, 234, 22, 1, 79, 159, 7, 221, 185, 230, 162, 211, 188, 249, 149, 102, 165, 248, 4, 10, 81, 61, 44, 138, 71, 43, 248, 185, 184, 17, 168, 128, 66, 159, 157, 188, 13, 169, 114, 5, 148, 162, 217, 57, 206, 18, 166, 4, 184, 199 } });
        }
    }
}
