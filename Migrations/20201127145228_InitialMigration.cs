using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeChallenge.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    SettleDate = table.Column<DateTime>(nullable: false),
                    Vat = table.Column<int>(nullable: false),
                    Currency = table.Column<int>(nullable: false),
                    ExchangeRate = table.Column<int>(nullable: false),
                    Client = table.Column<string>(nullable: true),
                    OrderId = table.Column<string>(nullable: true),
                    SaleAgent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
