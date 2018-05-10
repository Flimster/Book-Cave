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
            var orderByUserId = (from U in _db.AspNetUsers
                                 join OrUs in _db.UsersOrders on U.Id equals OrUs.AspNetUsersId
                                 join Ord in _db.Orders on OrUs.OrderId equals Ord.Id
                                select new OrderViewModel
                        { 
                            Id = Ord.Id,
                            User = (from Or in _db.Orders
                                    join OrUs in _db.UsersOrders on Or.Id equals OrUs.OrderId
                                    join Us in _db.AspNetUsers on OrUs.AspNetUsersId equals Us.Id
                                    select Us.Name).SingleOrDefault(),
                            Date = Ord.Date,
                            Status = Ord.Status,
                            Price = Ord.Price,
                            BookList = (from Or in _db.Orders
                                        join OrBo in _db.OrdersBooks on Or.Id equals OrBo.OrderId
                                        join Bo in _db.Books on OrBo.BookId equals Bo.Id
                                        select new BookViewModel
                                        {
                                            Id = Bo.Id,
                                            Title = Bo.Title,
                                            Authors =  (from Bok in _db.Books
                                                        join BoAu in _db.BooksAuthors on Bok.Id equals BoAu.Id
                                                        join Au in _db.Authors on BoAu.AuthorId equals Au.Id
                                                        select new AuthorViewModel
                                                        {
                                                            Id = Au.Id,
                                                            Name = Au.Name
                                                        }).ToList(),
                                            Genre = (from Bk in _db.Books
                                                     join BoGe in _db.BookGenres on Bk.Id equals BoGe.BookId
                                                     join Ge in _db.Genres on BoGe.GenreId equals Ge.Id
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
            return orderByUserId;
        }
    }
}