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
                            join Re in _db.Reviews on Us.Id equals Re.AspNetUserId
                            where R.AspNetUserId == Us.Id
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
                (from Rev in _db.Reviews
                where Rev.AspNetUserId == userId
                select new ReviewViewModel
                {
                    Id = Rev.Id,
                    UserName =
                        (from Usr in _db.AspNetUsers
                        where Usr.Id == userId
                        select Usr.Name).FirstOrDefault(),
                    Book =
                        (from Bok in _db.Books
                        join RevB in _db.Reviews on Bok.Id equals RevB.BookId
                        select Bok.Title).FirstOrDefault(),
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