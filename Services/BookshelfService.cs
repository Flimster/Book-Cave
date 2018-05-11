using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using BookCave.Repositories;

namespace BookCave.Services
{
    public class BookshelfService
    {
        private BookshelfRepo _bookshelfRepo;

        private DataContext _db;

        public BookshelfService()
        {
            _bookshelfRepo = new BookshelfRepo();
            _db = new DataContext();
        }

        public List<BookViewModel> GetByUserId(string userId)
        {
            return _bookshelfRepo.GetByUserId(userId);
        }
    }
}