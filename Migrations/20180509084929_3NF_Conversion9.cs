using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BookCave.Migrations
{
    public partial class _3NF_Conversion9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingAddressId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ShippingAddressId",
                table: "Orders",
                newName: "ShippingAddressesId");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "Orders",
                newName: "BillingAddressesId");

            migrationBuilder.RenameColumn(
                name: "Format",
                table: "Books",
                newName: "FormatsId");

            migrationBuilder.AddColumn<string>(
                name: "CustomId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillingAddressesId",
                table: "Orders",
                column: "BillingAddressesId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CardDetailsId",
                table: "Orders",
                column: "CardDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingAddressesId",
                table: "Orders",
                column: "ShippingAddressesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_BillingAddress_BillingAddressesId",
                table: "Orders",
                column: "BillingAddressesId",
                principalTable: "BillingAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_CardDetails_CardDetailsId",
                table: "Orders",
                column: "CardDetailsId",
                principalTable: "CardDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShippingAddresses_ShippingAddressesId",
                table: "Orders",
                column: "ShippingAddressesId",
                principalTable: "ShippingAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_BillingAddress_BillingAddressesId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CardDetails_CardDetailsId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShippingAddresses_ShippingAddressesId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_BillingAddressesId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CardDetailsId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ShippingAddressesId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ShippingAddressesId",
                table: "Orders",
                newName: "ShippingAddressId");

            migrationBuilder.RenameColumn(
                name: "BillingAddressesId",
                table: "Orders",
                newName: "BooksId");

            migrationBuilder.RenameColumn(
                name: "FormatsId",
                table: "Books",
                newName: "Format");

            migrationBuilder.AddColumn<int>(
                name: "BillingAddressId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);
        }
    }
}
