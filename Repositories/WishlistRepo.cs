using System.Collections.Generic;
using BookCave.Models.ViewModels;
using BookCave.Data;
using System.Linq;

namespace BookCave.Repositories
{
    public class WishlistRepo
    {
        private DataContext _db;

        public WishlistRepo()
        {
            _db = new DataContext();
        }

         public List<WishlistViewModel> GetByUserId(string Id)
        {
            var Whishlist = 
                (from W in _db.UsersWishlists
                select new WishlistViewModel
                {
                    AspNetUsersId = W.AspNetUserId,
                    Book = 
                        (from Wi in _db.UsersWishlists
                        join B in _db.Books on Wi.BookId equals B.Id
                        where Wi.AspNetUserId == Id
                        select new BookViewModel
                            {
                                Id = B.Id,
                                Title = B.Title,
                                Description = B.Description,
                                Publisher = B.Publisher,
                                Image = B.Image,
                                Price = B.Price,
                                ISBN10 = B.ISBN10,
                                ISBN13 = B.ISBN13,
                                ReleaseYear = B.ReleaseYear,
                                Rating = B.Rating,
                                StockCount = B.StockCount,
                                FormatId = B.FormatId,
                                Discount = B.Discount,
                                Languages = 
                                    (from BoLa in _db.BooksLanguages
                                    join La in _db.Languages on BoLa.LanguageId equals La.Id
                                    where BoLa.BookId == B.Id
                                    select new LanguagesViewModel
                                    {
                                        Name = La.Name
                                    }).ToList(),
                            
                                Authors = 
                                    (from BoAu in _db.BooksAuthors
                                    join Au in _db.Authors on BoAu.AuthorId equals Au.Id
                                    where BoAu.BookId == B.Id
                                    select new AuthorViewModel
                                    {
                                        Id = Au.Id,
                                        Name = Au.Name
                                    }).ToList(),
                                Genre = 
                                    (from BoGe in _db.BookGenres
                                    join Ge in _db.Genres on BoGe.GenreId equals Ge.Id
                                    where BoGe.BookId == B.Id
                                    select new GenreViewModel
                                    {
                                        Id = Ge.Id,
                                        Name = Ge.Name
                                    }).ToList()
                            }).ToList()
                }).ToList();
            return Whishlist;
        }
    }
}