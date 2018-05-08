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
                     
                            Authors = (from Bo in _db.Books
                                        join Ba in _db.BooksAuthors on B.Id equals Ba.Id
                                        join BoAu in _db.Authors on Ba.AuthorId equals BoAu.Id
                                        select new AuthorViewModel
                                        {
                                            Id = BoAu.Id,
                                            Name = BoAu.Name
                                        }).ToList(),
                            Genre = (from Bk in _db.Books
                                    join BoGe in _db.BookGenres on B.Id equals BoGe.BookId
                                    join Ge in _db.Genres on BoGe.GenreId equals Ge.Id
                                    select new GenreViewModel
                                    {
                                        Id = Ge.Id,
                                        Name = Ge.Name
                                    }).ToList(),
                            Image = B.Image,
                            Price = B.Price,
                            ISBN10 = B.ISBN10,
                            ISBN13 = B.ISBN13
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