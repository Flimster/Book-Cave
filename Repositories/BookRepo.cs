using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Collections.Generic;
using System.Linq;
using BookCave.Repositories;
using BookCave.Models.ViewModels;
using Book_Cave.Models.ViewModels;

namespace BookCave.Repositories
{
    public class BookRepo
    {
        private DataContext _db;
        
        public BookRepo()
        {
            _db = new DataContext();
        }

        public List<BookViewModel> GetBookList()
        {
            var Books = (from B in _db.Book
                        select new BookViewModel
                        {
                            Id = B.Id,
                            Title = B.Title,
                            Image = B.Image,
                            Price = B.Price,
                            Authors = (from Bo in _db.Book
                                    join Ba in _db.BookAuthors on Bo.Id equals Ba.Id
                                    join BoAu in _db.Author on Ba.AuthorId equals BoAu.Id
                                    select new AuthorViewModel
                                    {
                                        Id = BoAu.Id,
                                        Name = BoAu.Name
                                    }).ToList()
                        }).ToList();
            
            return Books;
        }

        public void WriteBook(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();
        }
    }
}