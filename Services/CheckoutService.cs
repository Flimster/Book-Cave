using System;
using System.Collections.Generic;
using System.Linq;
using BookCave.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace BookCave.Services
{
    public class CheckoutService
    {
        private readonly BookService _bookService;

        public CheckoutService()
        {
            _bookService = new BookService();
        }

        public List<BookViewModel> GetItemsInCart(List<int> Ids)
        {
            var books = _bookService.GetList();
            var cartItems = books.Where(b => Ids.Any(a => a == b.Id)).ToList();

            return cartItems;
        }

        public CartViewModel GetCartViewModel(List<BookViewModel> books)
        {
            var totalPrice = 0.0;
            foreach(var b in books)
            {
                totalPrice += b.Price;
            }

            var order = new CartViewModel() {
                BookList = books,
                Price = totalPrice,
            };
            return order;
        }
    }
}