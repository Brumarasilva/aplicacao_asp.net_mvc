using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aplicacao_asp.net_mvc.Migrations
{
    /// <inheritdoc />
    public partial class AddConcluidaToTarefa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Concluida",
                table: "Tarefas",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Concluida",
                table: "Tarefas");
        }
    }
}
