
using BookCave.Models.RegistrationModels;
using BookCave.Repositories;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Collections.Generic;
using BookCave.Models.ViewModels;

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

        public void WriteBook(BookRegistrationModel bookView)
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
            //_authorRepo.WriteAuthor(bookView.Authors);
        }
        
        public List<BookViewModel> GetList()
        {
            return _bookRepo.GetList();
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

    }
}