﻿// <auto-generated />
using BookCave.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace BookCave.Migrations
{
    [DbContext(typeof(AuthenticationDbContext))]
    partial class AuthenticationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookCave.Data.EntityModels.Authors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.BillingAddresses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<int>("CountryId");

                    b.Property<string>("StateOrProvince");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("BillingAddress");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<double>("Discount");

                    b.Property<int>("FormatsId");

                    b.Property<string>("ISBN10");

                    b.Property<string>("ISBN13");

                    b.Property<string>("Image");

                    b.Property<double>("Price");

                    b.Property<string>("Publisher");

                    b.Property<double>("Rating");

                    b.Property<int>("ReleaseYear");

                    b.Property<int>("StockCount");

                    b.Property<string>("Title");

                    b.Property<bool>("Visibility");

                    b.HasKey("Id");

                    b.HasIndex("FormatsId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.BooksAuthors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<int>("BookId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BooksAuthors");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.BooksGenres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<int>("GenreId");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("GenreId");

                    b.ToTable("BookGenres");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.BooksLanguages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<int>("LanguageId");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("LanguageId");

                    b.ToTable("BooksLanguages");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.CardDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardNumber");

                    b.Property<int>("Cvc");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CardDetails");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Feedbacks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AspNetUsersId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("OrderId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Formats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Formats");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Genres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Languages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BillingAddressesId");

                    b.Property<int>("CardDetailsId");

                    b.Property<DateTime>("Date");

                    b.Property<double>("Price");

                    b.Property<int>("ShippingAddressesId");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.HasIndex("BillingAddressesId");

                    b.HasIndex("CardDetailsId");

                    b.HasIndex("ShippingAddressesId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.OrdersBooks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<int>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrdersBooks");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.OwnedBooks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AspNetUsersId");

                    b.Property<int>("BookId");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.HasIndex("BookId");

                    b.ToTable("OwnedBooks");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.ReadBooks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AspNetUsersId");

                    b.Property<int>("BooksId");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.HasIndex("BooksId");

                    b.ToTable("ReadBooks");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Reviews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AspNetUsersId");

                    b.Property<int>("BookId");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Edited");

                    b.Property<int>("NegativeScore");

                    b.Property<int>("PositiveScore");

                    b.Property<double>("Rating");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.HasIndex("BookId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.ShippingAddresses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<int?>("CountriesId");

                    b.Property<int>("CountryId");

                    b.Property<string>("StateOrProvince");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.HasIndex("CountriesId");

                    b.ToTable("ShippingAddresses");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.UserBillingAddresses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("AspNetUsersId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("AspNetUsersId");

                    b.ToTable("UserBillingAddresses");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.UsersCards", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AspNetUsersId");

                    b.Property<int>("CardId");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.HasIndex("CardId");

                    b.ToTable("UsersCards");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.UsersOrders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AspNetUsersId");

                    b.Property<int>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.HasIndex("OrderId");

                    b.ToTable("UsersOrders");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.UsersReviews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AspNetUsersId");

                    b.Property<int>("ReviewId");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.HasIndex("ReviewId");

                    b.ToTable("UsersReviews");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.UsersShippingAddresses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("AspNetUsersId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("AspNetUsersId");

                    b.ToTable("UsersShippingAddresses");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Wishlists", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AspNetUsersId");

                    b.Property<int>("BookId");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.HasIndex("BookId");

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.AspNetUsers", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int?>("AuthorsId");

                    b.Property<bool>("BookSuggestionsEmail");

                    b.Property<int?>("BooksId");

                    b.Property<int>("FavoriteAuthorId");

                    b.Property<int>("FavoriteBookId");

                    b.Property<string>("Image");

                    b.Property<DateTime>("LastLoggedInDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<int>("TotalBans");

                    b.Property<int>("TotalReports");

                    b.HasIndex("AuthorsId");

                    b.HasIndex("BooksId");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator().HasValue("AspNetUsers");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.BillingAddresses", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.Countries", "Countries")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Books", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.Formats", "Formats")
                        .WithMany()
                        .HasForeignKey("FormatsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.BooksAuthors", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.Authors", "Authors")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookCave.Data.EntityModels.Books", "Books")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.BooksGenres", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.Books", "Books")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookCave.Data.EntityModels.Genres", "Genres")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.BooksLanguages", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.Books", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookCave.Data.EntityModels.Languages", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Feedbacks", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Orders", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.BillingAddresses", "BillingAddresses")
                        .WithMany()
                        .HasForeignKey("BillingAddressesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookCave.Data.EntityModels.CardDetails", "CardDetails")
                        .WithMany()
                        .HasForeignKey("CardDetailsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookCave.Data.EntityModels.ShippingAddresses", "ShippingAddresses")
                        .WithMany()
                        .HasForeignKey("ShippingAddressesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.OrdersBooks", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.Books", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookCave.Data.EntityModels.Orders", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.OwnedBooks", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId");

                    b.HasOne("BookCave.Data.EntityModels.Books", "Books")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.ReadBooks", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId");

                    b.HasOne("BookCave.Data.EntityModels.Books", "Books")
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Reviews", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId");

                    b.HasOne("BookCave.Data.EntityModels.Books", "Books")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.ShippingAddresses", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.Countries", "Countries")
                        .WithMany()
                        .HasForeignKey("CountriesId");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.UserBillingAddresses", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.BillingAddresses", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookCave.Data.EntityModels.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.UsersCards", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId");

                    b.HasOne("BookCave.Data.EntityModels.CardDetails", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.UsersOrders", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId");

                    b.HasOne("BookCave.Data.EntityModels.Orders", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.UsersReviews", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId");

                    b.HasOne("BookCave.Data.EntityModels.Reviews", "Reviews")
                        .WithMany()
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.UsersShippingAddresses", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.ShippingAddresses", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookCave.Data.EntityModels.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId");
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.Wishlists", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId");

                    b.HasOne("BookCave.Data.EntityModels.Books", "Books")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookCave.Data.EntityModels.AspNetUsers", b =>
                {
                    b.HasOne("BookCave.Data.EntityModels.Authors", "Authors")
                        .WithMany()
                        .HasForeignKey("AuthorsId");

                    b.HasOne("BookCave.Data.EntityModels.Books", "Books")
                        .WithMany()
                        .HasForeignKey("BooksId");
                });
#pragma warning restore 612, 618
        }
    }
}
