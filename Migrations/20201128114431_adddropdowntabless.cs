using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeChallenge.Migrations
{
    public partial class adddropdowntabless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ExchangeValue",
                table: "Currencies",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExchangeValue",
                table: "Currencies");
        }
    }
}
