using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCrudGame.Migrations
{
    public partial class moneey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Money",
                table: "players",
                type: "int",
                fixedLength: true,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Money",
                table: "players");
        }
    }
}
