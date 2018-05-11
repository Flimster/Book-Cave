using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BookCave.Migrations
{
    public partial class _3NF_Conversion13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AspNetUserId",
                table: "CardDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CardDetails_AspNetUserId",
                table: "CardDetails",
                column: "AspNetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardDetails_AspNetUsers_AspNetUserId",
                table: "CardDetails",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardDetails_AspNetUsers_AspNetUserId",
                table: "CardDetails");

            migrationBuilder.DropIndex(
                name: "IX_CardDetails_AspNetUserId",
                table: "CardDetails");

            migrationBuilder.DropColumn(
                name: "AspNetUserId",
                table: "CardDetails");
        }
    }
}
