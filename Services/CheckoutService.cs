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
        private readonly CookieService _cookieServie;
        private readonly IHttpContextAccessor _httpContextAccessor;  

        public CheckoutService(IHttpContextAccessor httpContextAccessor)
        {
            _bookService = new BookService();
            _cookieServie = new CookieService(httpContextAccessor);
        }

        public List<BookViewModel> GetItemsInCart(List<CartDataModel> Ids)
        {
            var books = _bookService.GetList();
            var cartItems = books.Where(b => Ids.Any(a => a.Id == b.Id)).ToList();

            return cartItems;
        }

        public CartViewModel GetCartViewModel(List<BookViewModel> books, List<CartDataModel> cartArr)
        {
            var totalPrice = 0.0;
            foreach(var b in books)
            {
                totalPrice += b.Price;
            }

            var orderBookList = new List<OrderBookViewModel>();
            foreach(var b in books)
            {
                orderBookList.Add( new OrderBookViewModel() 
                {
                    Id = b.Id,
                    Title = b.Title,
                    Authors = b.Authors,
                    Genre = b.Genre,
                    Language = b.Language,
                    Image = b.Image,
                    Price = b.Price,
                    ISBN10 = b.ISBN10,
                    ISBN13 = b.ISBN13,
                    Description = b.Description,
                    Languages = b.Languages,
                    Publisher = b.Publisher,
                    ReleaseYear = b.ReleaseYear,
                    Rating = b.Rating,
                    StockCount = b.StockCount,
                    FormatsId = b.FormatsId,
                    Discount = b.Discount,
                });
            }

            for (int i = 0; i < orderBookList.Count; i++)
            {
                orderBookList[i].NumOfBooks = cartArr[i].Quantity;
            }

            var order = new CartViewModel() {
                BookList = orderBookList,
                Price = totalPrice,

            };
            return order;
        }
    }
}