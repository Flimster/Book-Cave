using BookCave.Repositories;

namespace BookCave.Services
{
    public class BookService
    {
        private BookRepo _br;

        public BookService()
        {
            _br = new BookRepo();
        }


    }
}