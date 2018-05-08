using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;
using BookCave.Models.ViewModels;

namespace Book_Cave.Repositories
{
    public class OrderRepo
    {
        private DataContext _db;

        public OrderRepo()
        {
            _db = new DataContext();
        }

        public List<OrderViewModel> GetList()
        {
            var order = (from O in _db.Orders
                        select new OrderViewModel
                        {/* 
                            Id = O.Id,
                            User = (from a in _db.AspNetUsers
                                        join u in _db.AspNetUsers on O.AspNetUsersId equals u.Id
                                        select a).SingleOrDefault(),
                            OrderDate = O.OrderDate,
                            OrderStatus = O.OrderStatus,
                            OrderPrice = O.OrderPrice,
                            BookList = 
                            */}).ToList();

            return order;
        }

        public void Write(Orders order)
        {
            _db.Add(order);
            _db.SaveChanges();
        }

        public void Remove(Orders order)
        {
            _db.Remove(order);
            _db.SaveChanges();
        }
    }
}