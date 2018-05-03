using Microsoft.EntityFrameworkCore;
using Book_Cave.Data.DatabaseExtraction;
namespace BookCave.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Address> Addresses {get; set;}
        public DbSet<Author> Authors {get; set;}
        public DbSet<Book> Books {get; set;}
        public DbSet<BookAuthor> BookAuthors {get; set;}
        public DbSet<BookGenre> BookGenres {get; set;}
        public DbSet<BookLanguage> BookLanguages {get; set;}
        public DbSet<BookReview> BookReviews {get; set;}
        public DbSet<CardDetails> CardDetails {get; set;}
        public DbSet<Country> Countries {get; set;}
        public DbSet<Feedback> Feedbacks {get; set;}
        public DbSet<Format> Formats {get; set;}
        public DbSet<Genre> Genres {get; set;}
        public DbSet<Language> Languages {get; set;}
        public DbSet<OrderBooklist> OrderBooklists {get; set;}
        public DbSet<Orders> Orders {get; set;}
        public DbSet<OwnedBook> OwnedBooks {get; set;}
        public DbSet<Publisher> Publishers {get; set;}
        public DbSet<Review> Reviews {get; set;}
        public DbSet<UserAccount> UserAccounts {get; set;}
        public DbSet<UserBilling> UserBillings {get; set;}
        public DbSet<UserCard> UserCards {get; set;}
        public DbSet<UserPayment> UserPayments {get; set;}
        public DbSet<UserReadBook> UserReadBooks {get; set;}
        public DbSet<UserReview> UserReviews {get; set;}
        public DbSet<UserShipping> UserShippings {get; set;}
        public DbSet<Wishlist> Wishlists {get; set;}

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder
                .UseSqlServer(
                    "Server=tcp:verklegt2.database.windows.net,1433;Initial Catalog=VLN2_2018_H01;Persist Security Info=False;User ID=VLN2_2018_H01_usr;Password=cut3Rose64;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }        
    }
}