using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using BookCave.Repositories;
using System.Linq;

namespace BookCave.Services
{
    public class OrdersService
    {
        private OrderRepo _orderRepo;
        private BookRepo _bookRepo;
        private AuthorRepo _authorRepo;
        private GenreRepo _genereRepo;

        private DataContext _db;

        public OrdersService()
        {
            _orderRepo = new OrderRepo();
            _bookRepo = new BookRepo();
            _authorRepo = new AuthorRepo();
            _genereRepo = new GenreRepo();
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
    }
}