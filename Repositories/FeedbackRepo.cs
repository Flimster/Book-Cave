using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;
using BookCave.Models.ViewModels;

namespace BookCave.Repositories
{
    public class FeedbackRepo
    {
        private DataContext _db;
        private OrderRepo orderRepo;

        public FeedbackRepo()
        {
            _db = new DataContext();
            orderRepo = new OrderRepo();
        }

        public List<FeedbackViewModel> GetList()
        {
            var feedback = (from F in _db.Feedbacks
                        select new FeedbackViewModel
                        {
                            Id = F.Id,
                            UserName = (from Fe in _db.Feedbacks
                                        join Us in _db.AspNetUsers on Fe.AspNetUsersId equals Us.Id
                                        //where F.AspNetUsersId == Us.Id
                                        select Us.Name).SingleOrDefault(),
                            Order = (from Or in _db.Orders
                                     join Fe in _db.Feedbacks on Or.Id equals Fe.OrderId
                                     select new OrderViewModel
                                     {
                                         Id = Or.Id,
                                         User = (from Us in _db.Orders
                                                join UsOr in _db.UsersOrders on Us.Id equals UsOr.Id
                                                join As in _db.AspNetUsers on UsOr.AspNetUsersId equals As.Id
                                                //where Or.Id == UsOr.OrderId && UsOr.AspNetUsersId == As.Id  //CHECK
                                                select As.Name).SingleOrDefault(),
                                        Date = Or.Date,
                                        Status = Or.Status,
                                        Price = Or.Price,
                                        BookList = (from Ord in _db.Orders
                                        join OrBo in _db.OrdersBooks on Ord.Id equals OrBo.OrderId
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
                                                     }).ToList()
                                        }).ToList()
                                     }).ToList(),
                            Date = F.Date,
                            Text = F.Text      
                        }).ToList();   
            return feedback;
        }

        public void Write(Feedbacks feedback)
        {
            _db.Add(feedback);
            _db.SaveChanges();
        }

        public void Remove(Feedbacks feedback)
        {
            _db.Remove(feedback);
            _db.SaveChanges();
        }
    }
}