using Microsoft.EntityFrameworkCore;
using BookCave.Data.EntityModels;
namespace BookCave.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Address> Address {get; set;}
        public DbSet<Author> Author {get; set;}
        public DbSet<Book> Book {get; set;}
        public DbSet<CardDetails> CardDetails {get; set;}
        public DbSet<Country> Country {get; set;}
        public DbSet<Feedback> Feedback {get; set;}
        public DbSet<Format> Format {get; set;}
        public DbSet<Genre> Genre {get; set;}
        public DbSet<Language> Language {get; set;}
        public DbSet<Publisher> Publisher {get; set;}
        public DbSet<Review> Review {get; set;}

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder
                .UseSqlServer(
                    "Server=tcp:verklegt2.database.windows.net,1433;Initial Catalog=VLN2_2018_H01;Persist Security Info=False;User ID=VLN2_2018_H01_usr;Password=cut3Rose64;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }        
    }
}