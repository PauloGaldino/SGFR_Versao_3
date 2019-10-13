using Microsoft.EntityFrameworkCore.Migrations;

namespace InfraData.Migrations
{
    public partial class Atualizado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Email_Pessoa_PessoaId",
                table: "Email");

            migrationBuilder.DropIndex(
                name: "IX_Email_PessoaId",
                table: "Email");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Email",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Email_PessoaId",
                table: "Email",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Email_Pessoa_PessoaId",
                table: "Email",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
