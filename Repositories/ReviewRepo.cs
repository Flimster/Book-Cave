using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace BookCave.Repositories
{
    public class ReviewRepo
    {
        private DataContext _db;

        public ReviewRepo()
        {
            _db = new DataContext();
        }

        public List<Review> ReviewList()
        {
            var review = (from R in _db.Genre
                        select new Review
                        {
                            Id = R.Id,
                            Name = R.Name
                        }).ToList();
            
            return review;
        }

        public void WriteAuthor(Review review)
        {
            _db.Add(review);
            _db.SaveChanges();
        }
    }
}