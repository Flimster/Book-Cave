using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BookCave.Migrations
{
    public partial class _3NF_Conversion6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AspNetUsersId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "OrdersHistories");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AspNetUsersId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AspNetUsersId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "OrderStatus",
                table: "Orders",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "OrderPrice",
                table: "Orders",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "OrderBooksId",
                table: "Orders",
                newName: "BooksId");

            migrationBuilder.CreateTable(
                name: "UsersOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AspNetUsersId = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersOrders_AspNetUsers_AspNetUsersId",
                        column: x => x.AspNetUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersOrders_AspNetUsersId",
                table: "UsersOrders",
                column: "AspNetUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersOrders_OrderId",
                table: "UsersOrders",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersOrders");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Orders",
                newName: "OrderStatus");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Orders",
                newName: "OrderPrice");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "Orders",
                newName: "OrderBooksId");

            migrationBuilder.AddColumn<string>(
                name: "AspNetUsersId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrdersHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AspNetUsersId = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersHistories_AspNetUsers_AspNetUsersId",
                        column: x => x.AspNetUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdersHistories_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AspNetUsersId",
                table: "Orders",
                column: "AspNetUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersHistories_AspNetUsersId",
                table: "OrdersHistories",
                column: "AspNetUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersHistories_OrderId",
                table: "OrdersHistories",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AspNetUsersId",
                table: "Orders",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
