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
            var Books = (from B in _db.Books
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
                            FormatsId = B.FormatsId,
                            Discount = B.Discount,

                            Languages = (from BoLa in _db.BooksLanguages
                                         join Bo in _db.Books on BoLa.BookId equals Bo.Id 
                                         join La in _db.Languages on BoLa.LanguageId equals La.Id
                                         select new LanguagesViewModel
                                        {
                                          Name = La.Name
                                        }).ToList(),
                     
                            Authors = (from Bo in _db.Books
                                        join Ba in _db.BooksAuthors on Bo.Id equals Ba.Id
                                        join BoAu in _db.Authors on Ba.AuthorId equals BoAu.Id
                                        where B.Id == Ba.BookId && BoAu.Id == Ba.AuthorId   //CHECK 
                                        select new AuthorViewModel
                                        {
                                            Id = BoAu.Id,
                                            Name = BoAu.Name
                                        }).ToList(),
                            Genre = (from Bk in _db.Books
                                    join BoGe in _db.BookGenres on Bk.Id equals BoGe.BookId
                                    join Ge in _db.Genres on BoGe.GenreId equals Ge.Id
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