using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BookCave.Migrations
{
    public partial class _3NF_Conversion11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Authors_AuthorsId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Books_BooksId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Formats_FormatsId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_AspNetUsers_AspNetUsersId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_BillingAddress_BillingAddressesId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShippingAddresses_ShippingAddressesId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnedBooks_AspNetUsers_AspNetUsersId",
                table: "OwnedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_ReadBooks_AspNetUsers_AspNetUsersId",
                table: "ReadBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_ReadBooks_Books_BooksId",
                table: "ReadBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_AspNetUsersId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingAddresses_Countries_CountriesId",
                table: "ShippingAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBillingAddresses_AspNetUsers_AspNetUsersId",
                table: "UserBillingAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersCards_AspNetUsers_AspNetUsersId",
                table: "UsersCards");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersOrders_AspNetUsers_AspNetUsersId",
                table: "UsersOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersShippingAddresses_AspNetUsers_AspNetUsersId",
                table: "UsersShippingAddresses");

            migrationBuilder.DropTable(
                name: "UsersReviews");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropIndex(
                name: "IX_ShippingAddresses_CountriesId",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "CountriesId",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "FavoriteAuthorId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FavoriteBookId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AspNetUsersId",
                table: "UsersShippingAddresses",
                newName: "AspNetUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersShippingAddresses_AspNetUsersId",
                table: "UsersShippingAddresses",
                newName: "IX_UsersShippingAddresses_AspNetUserId");

            migrationBuilder.RenameColumn(
                name: "AspNetUsersId",
                table: "UsersOrders",
                newName: "AspNetUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersOrders_AspNetUsersId",
                table: "UsersOrders",
                newName: "IX_UsersOrders_AspNetUserId");

            migrationBuilder.RenameColumn(
                name: "AspNetUsersId",
                table: "UsersCards",
                newName: "AspNetUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersCards_AspNetUsersId",
                table: "UsersCards",
                newName: "IX_UsersCards_AspNetUserId");

            migrationBuilder.RenameColumn(
                name: "AspNetUsersId",
                table: "UserBillingAddresses",
                newName: "AspNetUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserBillingAddresses_AspNetUsersId",
                table: "UserBillingAddresses",
                newName: "IX_UserBillingAddresses_AspNetUserId");

            migrationBuilder.RenameColumn(
                name: "AspNetUsersId",
                table: "Reviews",
                newName: "AspNetUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_AspNetUsersId",
                table: "Reviews",
                newName: "IX_Reviews_AspNetUserId");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "ReadBooks",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "AspNetUsersId",
                table: "ReadBooks",
                newName: "AspNetUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ReadBooks_BooksId",
                table: "ReadBooks",
                newName: "IX_ReadBooks_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_ReadBooks_AspNetUsersId",
                table: "ReadBooks",
                newName: "IX_ReadBooks_AspNetUserId");

            migrationBuilder.RenameColumn(
                name: "AspNetUsersId",
                table: "OwnedBooks",
                newName: "AspNetUserId");

            migrationBuilder.RenameIndex(
                name: "IX_OwnedBooks_AspNetUsersId",
                table: "OwnedBooks",
                newName: "IX_OwnedBooks_AspNetUserId");

            migrationBuilder.RenameColumn(
                name: "ShippingAddressesId",
                table: "Orders",
                newName: "ShippingAddressId");

            migrationBuilder.RenameColumn(
                name: "BillingAddressesId",
                table: "Orders",
                newName: "BillingAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ShippingAddressesId",
                table: "Orders",
                newName: "IX_Orders_ShippingAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_BillingAddressesId",
                table: "Orders",
                newName: "IX_Orders_BillingAddressId");

            migrationBuilder.RenameColumn(
                name: "AspNetUsersId",
                table: "Feedbacks",
                newName: "AspNetUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_AspNetUsersId",
                table: "Feedbacks",
                newName: "IX_Feedbacks_AspNetUserId");

            migrationBuilder.RenameColumn(
                name: "FormatsId",
                table: "Books",
                newName: "FormatId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_FormatsId",
                table: "Books",
                newName: "IX_Books_FormatId");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "ShippingAddresses",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.CreateTable(
                name: "UsersWishlists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AspNetUserId = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersWishlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersWishlists_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersWishlists_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddresses_CountryId",
                table: "ShippingAddresses",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersBookRating_AspNetUserId",
                table: "UsersBookRating",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersBookRating_BookId",
                table: "UsersBookRating",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersWishlists_AspNetUserId",
                table: "UsersWishlists",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersWishlists_BookId",
                table: "UsersWishlists",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Authors_AuthorsId",
                table: "AspNetUsers",
                column: "AuthorsId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Books_BooksId",
                table: "AspNetUsers",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Formats_FormatId",
                table: "Books",
                column: "FormatId",
                principalTable: "Formats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_AspNetUsers_AspNetUserId",
                table: "Feedbacks",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_BillingAddress_BillingAddressId",
                table: "Orders",
                column: "BillingAddressId",
                principalTable: "BillingAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShippingAddresses_ShippingAddressId",
                table: "Orders",
                column: "ShippingAddressId",
                principalTable: "ShippingAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnedBooks_AspNetUsers_AspNetUserId",
                table: "OwnedBooks",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReadBooks_AspNetUsers_AspNetUserId",
                table: "ReadBooks",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReadBooks_Books_BookId",
                table: "ReadBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_AspNetUserId",
                table: "Reviews",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingAddresses_Countries_CountryId",
                table: "ShippingAddresses",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBillingAddresses_AspNetUsers_AspNetUserId",
                table: "UserBillingAddresses",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersCards_AspNetUsers_AspNetUserId",
                table: "UsersCards",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersOrders_AspNetUsers_AspNetUserId",
                table: "UsersOrders",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersShippingAddresses_AspNetUsers_AspNetUserId",
                table: "UsersShippingAddresses",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Authors_AuthorsId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Books_BooksId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Formats_FormatId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_AspNetUsers_AspNetUserId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_BillingAddress_BillingAddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShippingAddresses_ShippingAddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnedBooks_AspNetUsers_AspNetUserId",
                table: "OwnedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_ReadBooks_AspNetUsers_AspNetUserId",
                table: "ReadBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_ReadBooks_Books_BookId",
                table: "ReadBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_AspNetUserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingAddresses_Countries_CountryId",
                table: "ShippingAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBillingAddresses_AspNetUsers_AspNetUserId",
                table: "UserBillingAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersCards_AspNetUsers_AspNetUserId",
                table: "UsersCards");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersOrders_AspNetUsers_AspNetUserId",
                table: "UsersOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersShippingAddresses_AspNetUsers_AspNetUserId",
                table: "UsersShippingAddresses");

            migrationBuilder.DropTable(
                name: "UsersBookRating");

            migrationBuilder.DropTable(
                name: "UsersWishlists");

            migrationBuilder.DropIndex(
                name: "IX_ShippingAddresses_CountryId",
                table: "ShippingAddresses");

            migrationBuilder.RenameColumn(
                name: "AspNetUserId",
                table: "UsersShippingAddresses",
                newName: "AspNetUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersShippingAddresses_AspNetUserId",
                table: "UsersShippingAddresses",
                newName: "IX_UsersShippingAddresses_AspNetUsersId");

            migrationBuilder.RenameColumn(
                name: "AspNetUserId",
                table: "UsersOrders",
                newName: "AspNetUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersOrders_AspNetUserId",
                table: "UsersOrders",
                newName: "IX_UsersOrders_AspNetUsersId");

            migrationBuilder.RenameColumn(
                name: "AspNetUserId",
                table: "UsersCards",
                newName: "AspNetUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersCards_AspNetUserId",
                table: "UsersCards",
                newName: "IX_UsersCards_AspNetUsersId");

            migrationBuilder.RenameColumn(
                name: "AspNetUserId",
                table: "UserBillingAddresses",
                newName: "AspNetUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_UserBillingAddresses_AspNetUserId",
                table: "UserBillingAddresses",
                newName: "IX_UserBillingAddresses_AspNetUsersId");

            migrationBuilder.RenameColumn(
                name: "AspNetUserId",
                table: "Reviews",
                newName: "AspNetUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_AspNetUserId",
                table: "Reviews",
                newName: "IX_Reviews_AspNetUsersId");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "ReadBooks",
                newName: "BooksId");

            migrationBuilder.RenameColumn(
                name: "AspNetUserId",
                table: "ReadBooks",
                newName: "AspNetUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_ReadBooks_BookId",
                table: "ReadBooks",
                newName: "IX_ReadBooks_BooksId");

            migrationBuilder.RenameIndex(
                name: "IX_ReadBooks_AspNetUserId",
                table: "ReadBooks",
                newName: "IX_ReadBooks_AspNetUsersId");

            migrationBuilder.RenameColumn(
                name: "AspNetUserId",
                table: "OwnedBooks",
                newName: "AspNetUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_OwnedBooks_AspNetUserId",
                table: "OwnedBooks",
                newName: "IX_OwnedBooks_AspNetUsersId");

            migrationBuilder.RenameColumn(
                name: "ShippingAddressId",
                table: "Orders",
                newName: "ShippingAddressesId");

            migrationBuilder.RenameColumn(
                name: "BillingAddressId",
                table: "Orders",
                newName: "BillingAddressesId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ShippingAddressId",
                table: "Orders",
                newName: "IX_Orders_ShippingAddressesId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_BillingAddressId",
                table: "Orders",
                newName: "IX_Orders_BillingAddressesId");

            migrationBuilder.RenameColumn(
                name: "AspNetUserId",
                table: "Feedbacks",
                newName: "AspNetUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_AspNetUserId",
                table: "Feedbacks",
                newName: "IX_Feedbacks_AspNetUsersId");

            migrationBuilder.RenameColumn(
                name: "FormatId",
                table: "Books",
                newName: "FormatsId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_FormatId",
                table: "Books",
                newName: "IX_Books_FormatsId");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "ShippingAddresses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountriesId",
                table: "ShippingAddresses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FavoriteAuthorId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FavoriteBookId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UsersReviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AspNetUsersId = table.Column<string>(nullable: true),
                    ReviewId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersReviews_AspNetUsers_AspNetUsersId",
                        column: x => x.AspNetUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersReviews_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AspNetUsersId = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_AspNetUsers_AspNetUsersId",
                        column: x => x.AspNetUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wishlists_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddresses_CountriesId",
                table: "ShippingAddresses",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersReviews_AspNetUsersId",
                table: "UsersReviews",
                column: "AspNetUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersReviews_ReviewId",
                table: "UsersReviews",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_AspNetUsersId",
                table: "Wishlists",
                column: "AspNetUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_BookId",
                table: "Wishlists",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Authors_AuthorsId",
                table: "AspNetUsers",
                column: "AuthorsId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Books_BooksId",
                table: "AspNetUsers",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Formats_FormatsId",
                table: "Books",
                column: "FormatsId",
                principalTable: "Formats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_AspNetUsers_AspNetUsersId",
                table: "Feedbacks",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_BillingAddress_BillingAddressesId",
                table: "Orders",
                column: "BillingAddressesId",
                principalTable: "BillingAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShippingAddresses_ShippingAddressesId",
                table: "Orders",
                column: "ShippingAddressesId",
                principalTable: "ShippingAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnedBooks_AspNetUsers_AspNetUsersId",
                table: "OwnedBooks",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReadBooks_AspNetUsers_AspNetUsersId",
                table: "ReadBooks",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReadBooks_Books_BooksId",
                table: "ReadBooks",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_AspNetUsersId",
                table: "Reviews",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingAddresses_Countries_CountriesId",
                table: "ShippingAddresses",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBillingAddresses_AspNetUsers_AspNetUsersId",
                table: "UserBillingAddresses",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersCards_AspNetUsers_AspNetUsersId",
                table: "UsersCards",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersOrders_AspNetUsers_AspNetUsersId",
                table: "UsersOrders",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersShippingAddresses_AspNetUsers_AspNetUsersId",
                table: "UsersShippingAddresses",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
