using Book_Cave.Models.RegistrationModels;
using Book_Cave.Repositories;
using BookCave.Data;
using BookCave.Data.EntityModels;
using BookCave.Repositories;

namespace BookCave.Services
{
    public class BookService
    {
        private BookRepo _bookRepo;
        private PublisherRepo _publisherRepo;
        private AuthorRepo _authorRepo;
        private FormatsRepo _formatsRepo;

        private DataContext _db;

        public BookService()
        {
            _bookRepo = new BookRepo();
            _publisherRepo = new PublisherRepo();
            _authorRepo = new AuthorRepo();
            _formatsRepo = new FormatsRepo();
            _db = new DataContext();
        }

        public void WriteBook(BookRegistrationModel bookView)
        {
            //var publisher = GetPublisher();
            //var Formats = GetFormats();
            //var Author = GetAuthor();

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
                //Formats = _db.Formats.Where(t => );

                           /*var userProfiles = _dataContext.UserProfile
                               .Where(t => idList.Contains(t.Id)); */
                //Author = 
            };

            _bookRepo.WriteBook(book);
        }

        //public List<int> GetPublisher()
        //{

        //}

    }
}