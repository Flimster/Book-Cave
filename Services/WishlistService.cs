using System.Collections.Generic;
using BookCave.Data;
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
    }
}