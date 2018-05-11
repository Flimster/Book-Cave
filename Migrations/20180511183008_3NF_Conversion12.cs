using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BookCave.Migrations
{
    public partial class _3NF_Conversion12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersBookRating");

            migrationBuilder.AddColumn<string>(
                name: "AspNetUserId",
                table: "ShippingAddresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AspNetUserId",
                table: "BillingAddress",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddresses_AspNetUserId",
                table: "ShippingAddresses",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingAddress_AspNetUserId",
                table: "BillingAddress",
                column: "AspNetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillingAddress_AspNetUsers_AspNetUserId",
                table: "BillingAddress",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingAddresses_AspNetUsers_AspNetUserId",
                table: "ShippingAddresses",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillingAddress_AspNetUsers_AspNetUserId",
                table: "BillingAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingAddresses_AspNetUsers_AspNetUserId",
                table: "ShippingAddresses");

            migrationBuilder.DropIndex(
                name: "IX_ShippingAddresses_AspNetUserId",
                table: "ShippingAddresses");

            migrationBuilder.DropIndex(
                name: "IX_BillingAddress_AspNetUserId",
                table: "BillingAddress");

            migrationBuilder.DropColumn(
                name: "AspNetUserId",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "AspNetUserId",
                table: "BillingAddress");

            migrationBuilder.CreateTable(
                name: "UsersBookRating",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AspNetUserId = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersBookRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersBookRating_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersBookRating_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersBookRating_AspNetUserId",
                table: "UsersBookRating",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersBookRating_BookId",
                table: "UsersBookRating",
                column: "BookId");
        }
    }
}
