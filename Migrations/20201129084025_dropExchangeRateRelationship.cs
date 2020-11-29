using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeChallenge.Migrations
{
    public partial class dropExchangeRateRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_ExchangeRates_ExchangeRateId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ExchangeRateId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ExchangeRateId",
                table: "Invoices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ExchangeRateId",
                table: "Invoices",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ExchangeRateId",
                table: "Invoices",
                column: "ExchangeRateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_ExchangeRates_ExchangeRateId",
                table: "Invoices",
                column: "ExchangeRateId",
                principalTable: "ExchangeRates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
