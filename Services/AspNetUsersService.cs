using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using BookCave.Repositories;

namespace BookCave.Services
{
    public class AspNetUsersService
    {
        private AspNetUsersRepo _aspNetUserRepo;
        private BookRepo _bookRepo;
        private AuthorRepo _authorRepo;
        private GenreRepo _genreRepo;

        private DataContext _db;

        public AspNetUsersService()
        {
            _aspNetUserRepo = new AspNetUsersRepo();
            _bookRepo = new BookRepo();
            _authorRepo = new AuthorRepo();
            _genreRepo = new GenreRepo();
            _db = new DataContext();
        }

        public List<AspNetUserViewModel> GetList()
        {
            return _aspNetUserRepo.GetList();
        }

    }
}