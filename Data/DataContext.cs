using Microsoft.EntityFrameworkCore;
using Book_Cave.Data.DatabaseExtraction;
namespace BookCave.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Address> Address {get; set;}
        public DbSet<Author> Author {get; set;}
        public DbSet<Book> Book {get; set;}
        public DbSet<BookAuthor> BookAuthor {get; set;}
        public DbSet<BookGenre> BookGenre {get; set;}
        public DbSet<BookLanguage> BookLanguage {get; set;}
        public DbSet<BookReview> BookReview {get; set;}
        public DbSet<CardDetails> CardDetails {get; set;}
        public DbSet<Country> Country {get; set;}
        public DbSet<Feedback> Feedback {get; set;}
        public DbSet<Format> Format {get; set;}
        public DbSet<Genre> Genre {get; set;}
        public DbSet<Language> Language {get; set;}
        public DbSet<OrderBooklist> OrderBooklist {get; set;}
        public DbSet<Orders> Orders {get; set;}
        public DbSet<OwnedBook> OwnedBook {get; set;}
        public DbSet<Publisher> Publisher {get; set;}
        public DbSet<Review> Review {get; set;}
        public DbSet<UserAccount> UserAccount {get; set;}
        public DbSet<UserBilling> UserBilling {get; set;}
        public DbSet<UserCard> UserCard {get; set;}
        public DbSet<UserPayment> UserPayment {get; set;}
        public DbSet<UserReadBook> UserReadBook {get; set;}
        public DbSet<UserReview> UserReview {get; set;}
        public DbSet<UserShipping> UserShipping {get; set;}
        public DbSet<Wishlist> Wishlist {get; set;}

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder
                .UseSqlServer(
                    "Server=tcp:verklegt2.database.windows.net,1433;Initial Catalog=VLN2_2018_H01;Persist Security Info=False;User ID=VLN2_2018_H01_usr;Password=cut3Rose64;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }        
    }
}