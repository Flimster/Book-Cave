using BookCave.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace BookCave.Data
{
    public class AuthenticationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<AspNetUsers> AspNetUsers {get;set;}
        public DbSet<Authors> Authors {get; set;}
        public DbSet<BillingAddresses> BillingAddress {get; set;}
        public DbSet<Books> Books {get; set;}
        public DbSet<BooksAuthors> BooksAuthors {get;set;}
        public DbSet<BooksGenres> BookGenres {get;set;}
        public DbSet<BooksLanguages> BooksLanguages { get; set; }
        public DbSet<CardDetails> CardDetails {get; set;}
        public DbSet<Countries> Countries {get; set;}
        public DbSet<Feedbacks> Feedbacks {get; set;}
        public DbSet<Formats> Formats {get; set;}
        public DbSet<Genres> Genres {get; set;}
        public DbSet<Languages> Languages {get; set;}
        public DbSet<Orders> Orders {get; set;}
        public DbSet<OrdersBooks> OrdersBooks { get; set; }
        public DbSet<UsersOrders> UsersOrders { get; set; }
        public DbSet<OwnedBooks> OwnedBooks {get;set;}
        public DbSet<ReadBooks> ReadBooks {get;set;}
        public DbSet<Reviews> Reviews {get; set;}
        public DbSet<ShippingAddresses> ShippingAddresses { get; set; }
        public DbSet<UserBillingAddresses> UserBillingAddresses { get; set; }
        public DbSet<UsersCards> UsersCards { get; set; }
        public DbSet<UsersReviews> UsersReviews { get; set; }
        public DbSet<UsersShippingAddresses> UsersShippingAddresses {get;set;}
        public DbSet<Wishlists> Wishlists {get;set;}
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options) {}


        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
        }
    }
}