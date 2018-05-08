using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;
using BookCave.Models.ViewModels;

namespace Book_Cave.Repositories
{
    public class FeedbackRepo
    {
        private DataContext _db;
        private OrderRepo orderRepo;

        public FeedbackRepo()
        {
            _db = new DataContext();
            orderRepo = new OrderRepo();
        }

        public List<FeedbackViewModel> GetList()
        {
            var feedback = (from F in _db.Feedbacks
                        select new FeedbackViewModel
                        {
                            Id = F.Id,
                            UserName = (from Fe in _db.Feedbacks
                                        join Us in _db.AspNetUsers on Fe.AspNetUsersId equals Us.Id
                                        select Us.Name).ToString(),
                            Order = (from Or in _db.Orders
                                     join Fe in _db.Feedbacks on Or.Id equals Fe.OrderId
                                     select new OrderViewModel
                                     {
                                         Id = Or.Id,
                                         User = (from Us in _db.Orders
                                                join UsOr in _db.UsersOrders on Us.Id equals UsOr.Id
                                                join As in _db.AspNetUsers on UsOr.AspNetUsersId equals As.Id
                                                select As.Name).ToString(),
                                        Date = Or.Date,
                                        Status = Or.Status,
                                        Price = Or.Price,
                                     }).ToList(),
                            Date = F.Date,
                            Text = F.Text
                            
                        }).ToList();
            
            return feedback;
        }

        public void Write(Feedbacks feedback)
        {
            _db.Add(feedback);
            _db.SaveChanges();
        }

        public void Remove(Feedbacks feedback)
        {
            _db.Remove(feedback);
            _db.SaveChanges();
        }
    }
}