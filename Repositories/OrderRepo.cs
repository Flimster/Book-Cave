using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;
using BookCave.Models.ViewModels;


namespace BookCave.Repositories
{
    public class OrderRepo
    {
        private DataContext _db;
        private OrderBooksRepo _orderBooksRepo;
        private OrdersBooks _ordersBooks;

        public OrderRepo()
        {
            _db = new DataContext();
            _orderBooksRepo = new OrderBooksRepo();
            _ordersBooks = new OrdersBooks();
        }

        /*public List<OrderViewModel> GetList()
        {
            var order = (from O in _db.Orders
                        select new OrderViewModel
                        { 
                            Id = O.Id,
                            User = 
                                (from UsOr in _db.Orders
                                join Us in _db.AspNetUsers on UsOr.AspNetUserId equals Us.Id
                                where UsOr.OrderId == O.Id
                                select Us.Name).SingleOrDefault(),
                            Date = O.Date,
                            Status = O.Status,
                            Price = O.Price,
                            BookList = 
                                (from OrBo in _db.OrdersBooks
                                join Bo in _db.Books on OrBo.BookId equals Bo.Id
                                where OrBo.OrderId == O.Id
                                select new BookViewModel
                                {
                                    Id = Bo.Id,
                                    Title = Bo.Title,
                                    Authors =  
                                        (from BoAu in _db.BooksAuthors
                                        join Au in _db.Authors on BoAu.AuthorId equals Au.Id
                                        where BoAu.BookId == Bo.Id
                                        select new AuthorViewModel
                                        {
                                            Id = Au.Id,
                                            Name = Au.Name
                                        }).ToList(),
                                    Genre = 
                                        (from BoGe in _db.BookGenres
                                        join Ge in _db.Genres on BoGe.GenreId equals Ge.Id
                                        where BoGe.BookId == Bo.Id
                                        select new GenreViewModel
                                        {
                                            Id = Ge.Id,
                                            Name = Ge.Name
                                        }).ToList(),
                                    Image = Bo.Image,
                                    Price = Bo.Price,
                                    ISBN10 = Bo.ISBN10,
                                    ISBN13 = Bo.ISBN13

                                        }).ToList()
                            }).ToList();

            return order;
        }*/
        public List<OrderViewModel> GetByUserId(string Id)
        {
            var orderByUserId = 
                    (from Or in _db.Orders
                    where Or.AspNetUserId == Id 
                    select new OrderViewModel
                    { 
                        Id = Or.Id,
                        User = 
                            (from Us in _db.AspNetUsers
                            where Or.AspNetUserId == Id
                            select Us.Name).FirstOrDefault(),
                        Date = Or.Date,
                        Status = Or.Status,
                        Price = Or.Price,
                        BookList = 
                                (from OrBo in _db.OrdersBooks
                                join B in _db.Books on OrBo.BookId equals B.Id
                                where OrBo.OrderId == Or.Id
                                select new BookViewModel
                                {
                                    Id = B.Id,
                                    Title = B.Title,
                                    Description = B.Description,
                                    Publisher = B.Publisher,
                                    Image = B.Image,
                                    Price = B.Price,
                                    ISBN10 = B.ISBN10,
                                    ISBN13 = B.ISBN13,
                                    ReleaseYear = B.ReleaseYear,
                                    Rating = B.Rating,
                                    StockCount = B.StockCount,
                                    FormatId = B.FormatId,
                                    Discount = B.Discount,
                                    Languages = 
                                        (from BoLa in _db.BooksLanguages
                                        join La in _db.Languages on BoLa.LanguageId equals La.Id
                                        where BoLa.BookId == B.Id
                                        select new LanguagesViewModel
                                        {
                                            Name = La.Name
                                        }).ToList(),
                            
                                    Authors = 
                                        (from BoAu in _db.BooksAuthors
                                        join Au in _db.Authors on BoAu.AuthorId equals Au.Id
                                        where BoAu.BookId == B.Id
                                        select new AuthorViewModel
                                        {
                                            Id = Au.Id,
                                            Name = Au.Name
                                        }).ToList(),
                                    Genre = 
                                        (from BoGe in _db.BookGenres
                                        join Ge in _db.Genres on BoGe.GenreId equals Ge.Id
                                        where BoGe.BookId == B.Id
                                        select new GenreViewModel
                                        {
                                            Id = Ge.Id,
                                            Name = Ge.Name
                                        }).ToList(),
                                    Quantity =
                                        (from BoOr in _db.OrdersBooks
                                        join Ord in _db.Orders on BoOr.OrderId equals Ord.Id
                                        where Ord.AspNetUserId == Id
                                        select BoOr.Quantity).SingleOrDefault()
                                }).ToList(),
                    }).ToList();
            return orderByUserId;
        }

        public void Write(string UserId, Orders Order, List<OrderBookViewModel> Books)
        {
            _db.Add(Order);
            _db.SaveChanges();

            for(int i = 0; i < Books.Count; i++)
            {
                _ordersBooks.BookId = Books[i].Id;
                _ordersBooks.OrderId = Order.Id;
                _ordersBooks.Quantity = Books[i].NumOfBooks;
                _orderBooksRepo.Write(_ordersBooks);
            }
        }

        public void Remove(Orders Order)
        {
            _db.Remove(Order);
            _db.SaveChanges();
        }
    }
}

