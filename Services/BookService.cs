using BookCave.Repositories;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Collections.Generic;
using BookCave.Models.ViewModels;
using BookCave.Models.InputModel;
using System.Linq;
using System;

namespace BookCave.Services
{
    public class BookService
    {
        private BookRepo _bookRepo;
        private AuthorRepo _authorRepo;
        private FormatsRepo _formatsRepo;
        private readonly ReviewRepo _reviewRepo;

        private DataContext _db;

        public BookService()
        {
            _bookRepo = new BookRepo();
            _authorRepo = new AuthorRepo();
            _formatsRepo = new FormatsRepo();
            _db = new DataContext();
            _reviewRepo = new ReviewRepo();
        }

        public void WriteBook(BookInputModel bookView)
        {
            var book = new Books() {
                Title = bookView.Title,
                Image = bookView.Image,
                Price = bookView.Price,
                ISBN10 = bookView.ISBN10,
                ISBN13 = bookView.ISBN13,
                Description = bookView.Description,
                ReleaseYear = bookView.ReleaseYear,
                Visibility = bookView.Visibility,
                Publisher = bookView.Publisher,
                Rating = 0,
                StockCount = bookView.StockCount,
                Discount = bookView.Discount / 100,
            };

            

            var bookId = _bookRepo.Write(book);
            
            //Format && Author
            _authorRepo.WriteList(bookView.Authors);
            _formatsRepo.Write(bookView.Formats);
        }
        
        public List<BookViewModel> GetList()
        {
            return _bookRepo.GetList();
        }

        public BookViewModel GetBook(int id)
        {
            BookViewModel book = (from Bo in _bookRepo.GetList()
                        where Bo.Id == id
                        select Bo).SingleOrDefault();
            return book;
        }

        public void DeleteBook(int Id)
        {
            
        }

        public List<Authors> GetAuthorList()
        {
            return _authorRepo.GetList();
        }

        public List<ReviewViewModel> GetReviewList()
        {
            return _reviewRepo.GetList();
        }

        public List<BookViewModel> GetTop10()
        {
            var books = _bookRepo.GetList();
            books = (from Bo in books
                     orderby Bo.Rating descending
                     select Bo).Take(10).ToList();
            return books;
        }

        public List<BookViewModel> GetDiscount()
        {
            var books = _bookRepo.GetList();
            books = (from Bo in books
                     where Bo.Discount != 0
                     select Bo).ToList();
            return books;
        }

        public List<BookViewModel> Recommended()
        {
          var books = _bookRepo.GetList();
          books = books.OrderBy(Bo => Guid.NewGuid()).Take(5).ToList();
          //list = list.OrderBy(emp => Guid.NewGuid()).ToList();
          return books;
        }
    }
}