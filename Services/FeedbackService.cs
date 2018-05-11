using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using BookCave.Repositories;

namespace BookCave.Services
{
    public class FeedbackService
    {
        private FeedbackRepo _feedbackRepo;
        private BookRepo _bookRepo;
        private OrderRepo _orderRepo;
        private ReviewRepo _reviewRepo;
        private DataContext _db;

         public FeedbackService()
         {
             _feedbackRepo = new FeedbackRepo();
             _bookRepo = new BookRepo();
             _orderRepo = new OrderRepo();
             _reviewRepo = new ReviewRepo();
             _db = new DataContext();
         }

         public List<FeedbackViewModel> GetList()
         {
             return _feedbackRepo.GetList();
         }
    }
}