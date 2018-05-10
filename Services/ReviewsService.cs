using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;
using BookCave.Repositories;

namespace BookCave.Services
{
    public class ReviewsService
    {
        private DataContext _db;

        private ReviewRepo _reviewRepo;
        
        public ReviewsService()
        {
            _reviewRepo = new ReviewRepo();
            _db = new DataContext();
        }

        public List<ReviewViewModel> GetList()
        {
            return _reviewRepo.GetList();
        }

        public List<ReviewViewModel> GetByUserId(string userId)
        {
            return _reviewRepo.GetByUserId(userId);
        }

        public void Write(Reviews review)
        {
            _reviewRepo.Write(review);
        }

        public void Remove(Reviews review)
        {
            _reviewRepo.Remove(review);
        }
    }
}