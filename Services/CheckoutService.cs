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
        private readonly CookieService _cookieService;
        private readonly IHttpContextAccessor _httpContextAccessor;  

        public CheckoutService(IHttpContextAccessor httpContextAccessor)
        {
            _bookService = new BookService();
            _cookieService = new CookieService(httpContextAccessor);
        }

        public List<BookViewModel> GetItemsInCart(List<CartDataModel> Ids)
        {
            var books = _bookService.GetList();
            var cartItems = books.Where(b => Ids.Any(a => a.Id == b.Id)).ToList();

            return cartItems;
        }

        public CartViewModel GetCartViewModel()
        {
            var cartArr = _cookieService.GetCart();
            var books = GetItemsInCart(cartArr);

            var totalPrice = 0.0;
            var fullPrice = 0.0;
            var t = 0;
            foreach(var b in books)
            {
                totalPrice += b.Price * cartArr[t].Quantity * (1 - b.Discount);
                fullPrice += b.Price * cartArr[t].Quantity;
                t++;
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
                    Languages = b.Languages,
                    Image = b.Image,
                    Price = b.Price,
                    ISBN10 = b.ISBN10,
                    ISBN13 = b.ISBN13,
                    Description = b.Description,
                    Publisher = b.Publisher,
                    ReleaseYear = b.ReleaseYear,
                    Rating = b.Rating,
                    StockCount = b.StockCount,
                    FormatId = b.FormatId,
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
                FullPrice = fullPrice,
            };
            return order;
        }
    }
}