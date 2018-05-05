using BookCave.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;

namespace BookCave.Data
{
    public class AuthenticationDbContext : IdentityDbContext<AspNetUsers>
    {

        public DbSet<BillingAddress> BillingAddress {get; set;}
        public DbSet<ShippingAddress> ShippingAddress {get;set;}
       // public DbSet<AspNetUsers> AspNetUsers {get;set;}
        public DbSet<Author> Author {get; set;}
        public DbSet<Book> Book {get; set;}
        public DbSet<CardDetails> CardDetails {get; set;}
        public DbSet<Country> Country {get; set;}
        public DbSet<Feedback> Feedback {get; set;}
        public DbSet<Formats> Formats {get; set;}
        public DbSet<Genre> Genre {get; set;}
        public DbSet<Language> Language {get; set;}
        public DbSet<Publisher> Publisher {get; set;}
        public DbSet<Review> Review {get; set;}
        public DbSet<Order> Order {get; set;}
        //public DbSet<Payment> Payment {get;set;}
        public DbSet<OrderHistory> OrderHistory {get;set;}
        public DbSet<UserShippingAddresses> UserShippingAddresses {get;set;}
        public DbSet<UserBillingAddresses> UserBillingAddresses {get;set;}
        public DbSet<OwnedBooks> OwnedBooks {get;set;}
        public DbSet<ReadBooks> ReadBooks {get;set;}
        public DbSet<UserReviewList> UserReviewList {get;set;}
        public DbSet<Wishlist> Wishlist {get;set;}
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
        }
    }
}