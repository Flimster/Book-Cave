using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;
using BookCave.Repositories;

namespace BookCave.Services
{
    public class WishlistService
    {
        private WishlistRepo _wishlistRepo;

        private DataContext _db;

        public WishlistService()
        {
            _wishlistRepo = new WishlistRepo();
            _db = new DataContext();
        }
        public List<WishlistViewModel> GetByUserId(string userId)
        {
            return _wishlistRepo.GetByUserId(userId);
        }

        public void Write(UsersWishlists usersWishlists)
        {
            _db.Add(usersWishlists);
            _db.SaveChanges();
        }

        public void Remove(UsersWishlists usersWishlists)
        {
            _db.Remove(usersWishlists);
            _db.SaveChanges();
        }
    }
}