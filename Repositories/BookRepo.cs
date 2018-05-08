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
                            Image = B.Image,
                            Price = B.Price,
                            Authors = (from Bo in _db.Books
                                        join Ba in _db.BooksAuthors on Bo.Id equals Ba.Id
                                        join BoAu in _db.Authors on Ba.AuthorId equals BoAu.Id
                                        select new AuthorViewModel
                                        {
                                            Id = BoAu.Id,
                                            Name = BoAu.Name
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