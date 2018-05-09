using System.Collections.Generic;
using Book_Cave.Models.ViewModels;
using BookCave.Data;
using System.Linq;
using BookCave.Models.ViewModels;

namespace BookCave.Repositories
{
    public class WishlistRepo
    {
        private DataContext _db;

        public WishlistRepo()
        {
            _db = new DataContext();
        }

       /* public List<WishlistViewModel> GetList()
        {
            var wishlist = (from W in _db.Wishlists
                            select new WishlistViewModel
                            {
                                AspNetUsersId = W.AspNetUsersId,
                                Book = (from Us in _db.AspNetUsers
                                        join Wi in _db.Wishlists on Us.Id equals Wi.AspNetUsersId
                                        join Bo in _db.Books on Wi.BookId equals Bo.Id
                                        where Wi.Id == W.Id
                                        select new BookViewModel
                                        {
                                            Id = Bo.Id,

                                        }).ToList()
                            })
        }*/
    }
}