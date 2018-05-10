using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using System.Linq;
using BookCave.Data.EntityModels;

namespace BookCave.Repositories
{
    public class AspNetUsersRepo
    {
        private DataContext _db;

        public AspNetUsersRepo()
        {
            _db = new DataContext();
        }

        public List<AspNetUserViewModel> GetList()
        {
            var users = (from U in _db.AspNetUsers
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
                                                            //where Up.Id == BoAu.BookId && Au.Id == BoAu.AuthorId    //CHECK
                                                            select new AuthorViewModel
                                                            {
                                                                Id = Au.Id,
                                                                Name = Au.Name
                                                            }).ToList(),
                                                Genre = (from Bk in _db.Books
                                                        join BoGe in _db.BookGenres on Bk.Id equals BoGe.BookId
                                                        join Ge in _db.Genres on BoGe.GenreId equals Ge.Id
                                                        //where Up.Id == BoGe.BookId && Ge.Id == BoGe.GenreId     //CHECK
                                                        select new GenreViewModel
                                                        {
                                                            Id = Ge.Id,
                                                            Name = Ge.Name
                                                        }).ToList(),
                                                            Image = Up.Image,
                                                            Price = Up.Price,
                                                            ISBN10 = Up.ISBN10,
                                                            ISBN13 = Up.ISBN13 }).FirstOrDefault(),
                            FavoriteAuthor = (from Us in _db.AspNetUsers
                                                join Au in _db.Authors on Us.FavoriteAuthorId equals Au.Id
                                               //where U.FavoriteAuthorId == Au.Id   //CHECK
                                                select new AuthorViewModel
                                                {
                                                    Id = Au.Id,
                                                    Name = Au.Name
                                                }).FirstOrDefault(),
                            RegistrationDate = U.RegistrationDate,
                            LastLoginDate = U.LastLoggedInDate,
                            BookSuggestionsEmail = U.BookSuggestionsEmail,
                            TotalReports = U.TotalReports,
                            TotalBans = U.TotalBans
                            }).ToList();
            return users;
        }
    }
}