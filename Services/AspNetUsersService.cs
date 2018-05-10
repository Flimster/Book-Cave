using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using BookCave.Repositories;
using System.Linq;
using BookCave.Data.EntityModels;

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
        public AspNetUserViewModel GetById(string Id)
        {
            var user = (from U in _db.AspNetUsers
                        where U.Id == Id
                        select new AspNetUserViewModel
                        {
                            Image = U.Image,
                            Name = U.Name,
                            FavoriteBook = (from Us in _db.AspNetUsers   
                                            from Up in _db.Books
                                            where Us.FavoriteBookId == Up.Id          
                                            select new BookViewModel
                                            {
                                                Id = Up.Id,
                                                Title = Up.Title,
                                                Authors =  (from Bok in _db.Books
                                                            join BoAu in _db.BooksAuthors on Bok.Id equals BoAu.Id
                                                            join Au in _db.Authors on BoAu.AuthorId equals Au.Id
                                                            select new AuthorViewModel
                                                            {
                                                                Id = Au.Id,
                                                                Name = Au.Name
                                                            }).ToList(),
                                                Genre = (from Bk in _db.Books
                                                        join BoGe in _db.BookGenres on Bk.Id equals BoGe.BookId
                                                        join Ge in _db.Genres on BoGe.GenreId equals Ge.Id
                                                        select new GenreViewModel
                                                        {
                                                            Id = Ge.Id,
                                                            Name = Ge.Name
                                                        }).ToList(),
                                                            Image = Up.Image,
                                                            Price = Up.Price,
                                                            ISBN10 = Up.ISBN10,
                                                            ISBN13 = Up.ISBN13 }).SingleOrDefault(),
                            FavoriteAuthor = (from Us in _db.AspNetUsers
                                                join Au in _db.Authors on Us.FavoriteAuthorId equals Au.Id
                                                select new AuthorViewModel
                                                {
                                                    Id = Au.Id,
                                                    Name = Au.Name
                                                }).SingleOrDefault(),
                            RegistrationDate = U.RegistrationDate,
                            LastLoginDate = U.LastLoggedInDate,
                            BookSuggestionsEmail = U.BookSuggestionsEmail,
                            TotalReports = U.TotalReports,
                            TotalBans = U.TotalBans
                        }
                        ).SingleOrDefault();
                        return user;
        }
    }
}   