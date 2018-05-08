using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using System.Linq;

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
                            FavoriteBook = (from Or in _db.Orders
                                            join OrBo in _db.OrdersBooks on Or.Id equals OrBo.OrderId
                                            join Bo in _db.Books on OrBo.BookId equals Bo.Id
                                            select new BookViewModel
                                            {
                                                Id = Bo.Id,
                                                Title = Bo.Title,
                                                Authors =  (from Bok in _db.Books
                                                            join BoAu in _db.BooksAuthors on Bok.Id equals BoAu.Id
                                                            join Au in _db.Authors on BoAu.AuthorId equals Au.Id
                                                            where Bo.Id == BoAu.BookId && Au.Id == BoAu.AuthorId    //CHECK
                                                            select new AuthorViewModel
                                                            {
                                                                Id = Au.Id,
                                                                Name = Au.Name
                                                            }).ToList(),
                                                Genre = (from Bk in _db.Books
                                                        join BoGe in _db.BookGenres on Bk.Id equals BoGe.BookId
                                                        join Ge in _db.Genres on BoGe.GenreId equals Ge.Id
                                                        where Bo.Id == BoGe.BookId && Ge.Id == BoGe.GenreId     //CHECK
                                                        select new GenreViewModel
                                                        {
                                                            Id = Ge.Id,
                                                            Name = Ge.Name
                                                        }).ToList(),
                                                            Image = Bo.Image,
                                                            Price = Bo.Price,
                                                            ISBN10 = Bo.ISBN10,
                                                            ISBN13 = Bo.ISBN13 }).ToList(),
                            FavoriteAuthor = (from Us in _db.AspNetUsers
                                                join Au in _db.Authors on Us.FavoriteAuthorId equals Au.Id
                                                where U.FavoriteAuthorId == Au.Id   //CHECK
                                                select new AuthorViewModel
                                                {
                                                    Id = Au.Id,
                                                    Name = Au.Name
                                                }).ToList(),
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