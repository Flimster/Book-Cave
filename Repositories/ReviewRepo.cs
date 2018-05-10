using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;
using BookCave.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookCave.Repositories
{
    public class ReviewRepo
    {
        private DataContext _db;
        
        public ReviewRepo()
        {
            _db = new DataContext();
        }

        public List<ReviewViewModel> GetList()
        {
            var review = 
                (from R in _db.Reviews
                    select new ReviewViewModel
                    {
                        Id = R.Id,
                        UserName = 
                            (from Us in _db.AspNetUsers
                            join Re in _db.Reviews on Us.Id equals Re.AspNetUsersId
                            where R.AspNetUsersId == Us.Id
                            select Us.Name).SingleOrDefault(),
                        Book = 
                            (from Re in _db.Reviews
                            join Bo in _db.Books on Re.BookId equals Bo.Id
                            where R.BookId == Bo.Id
                            select Bo.Title).SingleOrDefault(),
                        Text = R.Text,
                        Rating = R.Rating,
                        Date = R.Date,
                        PositiveScore = R.PositiveScore,
                        NegativeScore = R.NegativeScore,
                        Edited = R.Edited
                    }).ToList();
            return review;
        }

        public List<ReviewViewModel> GetByUserId(string userId)
        {
            var userReviews =
                (from UsRv in _db.UsersReviews
                join Rev in _db.Reviews on UsRv.ReviewId equals Rev.Id
                where UsRv.AspNetUsersId == userId
                select new ReviewViewModel
                {
                    Id = Rev.Id,
                    UserName =
                        (from Usr in _db.AspNetUsers
                        where Usr.Id == userId
                        select Usr.Name).SingleOrDefault(),
                    Book =
                        (from Bok in _db.Books
                        join BkRe in _db.UsersReviews on Rev.Id equals BkRe.ReviewId
                        where BkRe.AspNetUsersId == userId
                        select Bok.Title).SingleOrDefault(),
                    Text = Rev.Text,
                    Rating = Rev.Rating,
                    Date = Rev.Date,
                    PositiveScore = Rev.PositiveScore,
                    NegativeScore = Rev.NegativeScore,
                    Edited = Rev.Edited
                }).ToList();
            return userReviews;
        }

        public void Write(Reviews review)
        {
            _db.Add(review);
            _db.SaveChanges();
        }

        public void Remove(Reviews review)
        {
            _db.Remove(review);
            _db.SaveChanges();
        }
    }
}