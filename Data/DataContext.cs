using Microsoft.EntityFrameworkCore;
using BookCave.Data.EntityModels;
namespace BookCave.Data
{
    public class DataContext : DbContext
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
        public DbSet<ReadBooks> ReadBooks {get;set;}
        public DbSet<Review> Review {get; set;}
        public DbSet<ShippingAddress> ShippingAddress { get; set; }
        public DbSet<UserBillingAddresses> UserBillingAddresses { get; set; }
        public DbSet<UserCards> UserCards { get; set; }
        public DbSet<UserReview> UserReviewList {get;set;}
        public DbSet<UserShippingAddresses> UserShippingAddresses {get;set;}
        public DbSet<Wishlist> Wishlist {get;set;}

                
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder
                .UseSqlServer(
                    "Server=tcp:verklegt2.database.windows.net,1433;Initial Catalog=VLN2_2018_H01;Persist Security Info=False;User ID=VLN2_2018_H01_usr;Password=cut3Rose64;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }        
    }
}