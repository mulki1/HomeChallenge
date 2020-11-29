using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeChallenge.Migrations
{
    public partial class adddropdowntables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Client",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Vat",
                table: "Invoices");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "Invoices",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CurrencyId",
                table: "Invoices",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ExchangeRateId",
                table: "Invoices",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "VatId",
                table: "Invoices",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Amount = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vats",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Value = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vats", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ClientId",
                table: "Invoices",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CurrencyId",
                table: "Invoices",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ExchangeRateId",
                table: "Invoices",
                column: "ExchangeRateId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_VatId",
                table: "Invoices",
                column: "VatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Clients_ClientId",
                table: "Invoices",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Currencies_CurrencyId",
                table: "Invoices",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_ExchangeRates_ExchangeRateId",
                table: "Invoices",
                column: "ExchangeRateId",
                principalTable: "ExchangeRates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Vats_VatId",
                table: "Invoices",
                column: "VatId",
                principalTable: "Vats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Clients_ClientId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Currencies_CurrencyId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_ExchangeRates_ExchangeRateId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Vats_VatId",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "ExchangeRates");

            migrationBuilder.DropTable(
                name: "Vats");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ClientId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_CurrencyId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ExchangeRateId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_VatId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ExchangeRateId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "VatId",
                table: "Invoices");

            migrationBuilder.AddColumn<string>(
                name: "Client",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Currency",
                table: "Invoices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExchangeRate",
                table: "Invoices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vat",
                table: "Invoices",
                nullable: false,
                defaultValue: 0);
        }
    }
}
