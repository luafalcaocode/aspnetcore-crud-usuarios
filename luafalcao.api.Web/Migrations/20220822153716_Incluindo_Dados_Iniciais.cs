using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace luafalcao.api.Web.Migrations
{
    public partial class Incluindo_Dados_Iniciais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Escolaridade",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "Infantil" },
                    { 2, "Fundamental" },
                    { 3, "Médio" },
                    { 4, "Superior" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataNascimento", "EscolaridadeId", "HistoricoEscolarId", "Nome", "Sobrenome" },
                values: new object[] { 1, new DateTime(1990, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "José", "Silva" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataNascimento", "EscolaridadeId", "HistoricoEscolarId", "Nome", "Sobrenome" },
                values: new object[] { 2, new DateTime(1975, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Julia", "Silva" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataNascimento", "EscolaridadeId", "HistoricoEscolarId", "Nome", "Sobrenome" },
                values: new object[] { 3, new DateTime(1968, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "João", "Silva" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
