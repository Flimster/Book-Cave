using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BookCave.Migrations
{
    public partial class _3NF_Conversion8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "FormatsId",
                table: "Books",
                newName: "Format");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Format",
                table: "Books",
                newName: "FormatsId");

            migrationBuilder.AddColumn<string>(
                name: "CustomId",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
