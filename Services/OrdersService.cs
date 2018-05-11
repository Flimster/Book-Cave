using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using BookCave.Repositories;
using System.Linq;
using BookCave.Data.EntityModels;
using System;

namespace BookCave.Services
{
    public class OrdersService
    {
        private OrderRepo _orderRepo;
        private DataContext _db;

        public OrdersService()
        {
            _orderRepo = new OrderRepo();
            _db = new DataContext();
        }
        public List<OrderViewModel> GetByUserId(string Id)
        {
            return _orderRepo.GetByUserId(Id);
        }

        public void WriteOrdersBooks(string id, CheckoutViewModel model)
        {
            var order = new Orders
            {
                Date = DateTime.Now,
                Status = false,
                Price = model.Order.Price,
                ShippingAddressId = model.SelectedShipping.Id,
                BillingAddressId = model.SelectedBilling.Id,
                CardDetailsId = model.SelectedCard.Id,
                AspNetUserId = id,
            };

            _orderRepo.Write(id, order, model.Order.BookList);

        }
    }
}