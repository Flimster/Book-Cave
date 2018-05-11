using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using System.Linq;
using BookCave.Data.EntityModels;

namespace BookCave.Repositories
{
    public class BookReadRepo
    {
        private DataContext _db;
        public BookReadRepo()
        {
            _db = new DataContext();
        }
        public List<BookViewModel> GetByUserId(string userId)
        {
            var readBooks =
                (from UsRe in _db.ReadBooks
                join B in _db.Books on UsRe.BookId equals B.Id
                where UsRe.AspNetUserId == userId
                select new BookViewModel
                {
                    Id = B.Id,
                    Title = B.Title,
                    Description = B.Description,
                    Publisher = B.Publisher,
                    Image = B.Image,
                    Price = B.Price,
                    ISBN10 = B.ISBN10,
                    ISBN13 = B.ISBN13,
                    ReleaseYear = B.ReleaseYear,
                    Rating = B.Rating,
                    StockCount = B.StockCount,
                    /*Format = 
                        (from Fo in _db.Formats
                        where Fo.Id == B.FormatId
                        select Fo).SingleOrDefault(),*/
                    Discount = B.Discount,
                    Languages = 
                        (from BoLa in _db.BooksLanguages
                        join La in _db.Languages on BoLa.LanguageId equals La.Id
                        where BoLa.BookId == B.Id
                        select new LanguagesViewModel
                        {
                            Name = La.Name
                        }).ToList(),
                
                    Authors = 
                        (from BoAu in _db.BooksAuthors
                        join Au in _db.Authors on BoAu.AuthorId equals Au.Id
                        where BoAu.BookId == B.Id
                        select new AuthorViewModel
                        {
                            Id = Au.Id,
                            Name = Au.Name
                        }).ToList(),
                    Genre = 
                        (from BoGe in _db.BookGenres
                        join Ge in _db.Genres on BoGe.GenreId equals Ge.Id
                        where BoGe.BookId == B.Id
                        select new GenreViewModel
                        {
                            Id = Ge.Id,
                            Name = Ge.Name
                        }).ToList()
                }).ToList();
            return readBooks;
        }
        public void Write(ReadBooks readBooks)
        {
            _db.Add(readBooks);
            _db.SaveChanges();
        }

        public void Remove(ReadBooks readBooks)
        {
            _db.Remove(readBooks);
            _db.SaveChanges();
        }
    }
}