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
                        { 
                            Id = O.Id,
                            User = (from Us in _db.Orders
                                    join UsOr in _db.UsersOrders on Us.Id equals UsOr.Id
                                    join As in _db.AspNetUsers on UsOr.AspNetUsersId equals As.Id
                                    where O.Id == UsOr.OrderId && UsOr.AspNetUsersId == As.Id   //CHECK
                                    select As.Name).ToString(),
                            Date = O.Date,
                            Status = O.Status,
                            Price = O.Price,
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