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
        public DbSet<Author> Author {get; set;}
        public DbSet<BillingAddress> BillingAddress {get; set;}
        public DbSet<Book> Book {get; set;}
        public DbSet<BookAuthors> BookAuthors {get;set;}
        public DbSet<BookGenre> BookGenre {get;set;}
        public DbSet<BookLanguages> BookLanguages { get; set; }
        public DbSet<CardDetails> CardDetails {get; set;}
        public DbSet<Country> Country {get; set;}
        public DbSet<Feedback> Feedback {get; set;}
        public DbSet<Formats> Formats {get; set;}
        public DbSet<Genre> Genre {get; set;}
        public DbSet<Language> Language {get; set;}
        public DbSet<Order> Order {get; set;}
        public DbSet<OrderBooks> OrderBooks { get; set; }
        public DbSet<OrderHistory> OrderHistory { get; set; }
        public DbSet<OwnedBooks> OwnedBooks {get;set;}
        public DbSet<Publisher> Publisher {get; set;}
        public DbSet<ReadBooks> ReadBooks {get;set;}
        public DbSet<Review> Review {get; set;}
        public DbSet<ShippingAddress> ShippingAddress { get; set; }
        public DbSet<UserBillingAddresses> UserBillingAddresses { get; set; }
        public DbSet<UserCards> UserCards { get; set; }
        public DbSet<UserReviewList> UserReviewList {get;set;}
        public DbSet<UserReviews> UserReviews { get; set; }
        public DbSet<UserShippingAddresses> UserShippingAddresses {get;set;}
        public DbSet<Wishlist> Wishlist {get;set;}
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
        }
    }
}