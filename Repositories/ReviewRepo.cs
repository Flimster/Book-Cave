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
            
            
            var review = (from R in _db.Reviews
                        select new ReviewViewModel
                        {
                            Id = R.Id,
                            UserName = (from Us in _db.AspNetUsers
                                        join Re in _db.Reviews on Us.Id equals Re.AspNetUsersId
                                        where R.AspNetUsersId == Us.Id
                                        select Us.Name).SingleOrDefault(),
                            Book = (from Re in _db.Reviews
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