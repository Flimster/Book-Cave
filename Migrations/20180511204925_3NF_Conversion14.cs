using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BookCave.Migrations
{
    public partial class _3NF_Conversion14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBillingAddresses");

            migrationBuilder.DropTable(
                name: "UsersCards");

            migrationBuilder.DropTable(
                name: "UsersShippingAddresses");

            migrationBuilder.AddColumn<string>(
                name: "AspNetUserId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AspNetUserId",
                table: "Orders",
                column: "AspNetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AspNetUserId",
                table: "Orders",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AspNetUserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AspNetUserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AspNetUserId",
                table: "Orders");

            migrationBuilder.CreateTable(
                name: "UserBillingAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressId = table.Column<int>(nullable: false),
                    AspNetUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBillingAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBillingAddresses_BillingAddress_AddressId",
                        column: x => x.AddressId,
                        principalTable: "BillingAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBillingAddresses_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AspNetUserId = table.Column<string>(nullable: true),
                    CardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersCards_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersCards_CardDetails_CardId",
                        column: x => x.CardId,
                        principalTable: "CardDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersShippingAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressId = table.Column<int>(nullable: false),
                    AspNetUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersShippingAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersShippingAddresses_ShippingAddresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "ShippingAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersShippingAddresses_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserBillingAddresses_AddressId",
                table: "UserBillingAddresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBillingAddresses_AspNetUserId",
                table: "UserBillingAddresses",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCards_AspNetUserId",
                table: "UsersCards",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCards_CardId",
                table: "UsersCards",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersShippingAddresses_AddressId",
                table: "UsersShippingAddresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersShippingAddresses_AspNetUserId",
                table: "UsersShippingAddresses",
                column: "AspNetUserId");
        }
    }
}
