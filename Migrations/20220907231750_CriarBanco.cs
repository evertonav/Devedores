using Microsoft.EntityFrameworkCore.Migrations;

namespace Devedores.Migrations
{
    public partial class CriarBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devedor_Pessoa_PessoaId",
                table: "Devedor");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoa",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PessoaId",
                table: "Devedor",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Devedor_Pessoa_PessoaId",
                table: "Devedor",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devedor_Pessoa_PessoaId",
                table: "Devedor");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoa",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PessoaId",
                table: "Devedor",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Devedor_Pessoa_PessoaId",
                table: "Devedor",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
