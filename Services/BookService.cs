
using BookCave.Models.RegistrationModels;
using BookCave.Repositories;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Collections.Generic;

namespace BookCave.Services
{
    public class BookService
    {
        private BookRepo _bookRepo;
        private AuthorRepo _authorRepo;
        private FormatsRepo _formatsRepo;

        private DataContext _db;

        public BookService()
        {
            _bookRepo = new BookRepo();
            _authorRepo = new AuthorRepo();
            _formatsRepo = new FormatsRepo();
            _db = new DataContext();
        }

        public void WriteBook(BookRegistrationModel bookView)
        {
            var book = new Book() {
                Title = bookView.Title,
                Image = bookView.Image,
                Price = bookView.Price,
                ISBN10 = bookView.ISBN10,
                ISBN13 = bookView.ISBN13,
                Description = bookView.Description,
                ReleaseYear = bookView.ReleaseYear,
                Visibility = bookView.Visibility,
                Publisher = bookView.Publisher,

                //BookFormat = bookView.Formats,

                //Formats = _db.Formats.Where(t => );

                           /*var userProfiles = _dataContext.UserProfile
                               .Where(t => idList.Contains(t.Id)); */
                //Author = 

            };

            _authorRepo.WriteAuthor(bookView.Author);
            _bookRepo.WriteBook(book);
        }

        public List<Author> GetAuthor()
        {
            return _authorRepo.GetAuthorList();
        }

    }
}