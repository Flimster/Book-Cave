using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Collections.Generic;
using System.Linq;
using BookCave.Repositories;
using BookCave.Models.ViewModels;

namespace BookCave.Repositories
{
    public class BookRepo
    {
        private DataContext _db;
        
        public BookRepo()
        {
            _db = new DataContext();
        }
        public List<BookViewModel> GetList()
        {
            var Books = 
                (from B in _db.Books
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
                    Format = 
                        (from Fo in _db.Formats
                        where Fo.Id == B.FormatId
                        select Fo).SingleOrDefault(),
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
            return Books;
        }
        public int Write(Books book)
        {
            _db.Add(book);
            _db.SaveChanges();           
            return book.Id;
        }

        public void Remove(Books book)
        {
            _db.Remove(book);
            _db.SaveChanges();
        }
    }
}