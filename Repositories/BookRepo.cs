using BookCave.Data;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

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
                            //Author = (from
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