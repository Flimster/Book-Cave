using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using BookCave.Repositories;
using System.Linq;
using BookCave.Data.EntityModels;

namespace BookCave.Services
{
    public class OrdersService
    {
        private OrderRepo _orderRepo;
        private OrderBooksRepo _orderBooksRepo;
        private DataContext _db;

        public OrdersService()
        {
            _orderRepo = new OrderRepo();
            _orderBooksRepo = new OrderBooksRepo();
            _db = new DataContext();
        }

        public List<OrderViewModel> GetList()
        {
            return _orderRepo.GetList();
        }

        public List<OrderViewModel> GetByUserId(string Id)
        {
            return _orderRepo.GetByUserId(Id);
        }

        public void WriteOrdersBooks(OrdersBooks ordersBooks)
        {
            _orderBooksRepo.Write(ordersBooks);
        }
    }
}