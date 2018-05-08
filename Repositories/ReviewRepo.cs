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

        public List<Reviews> ReviewList()
        {
            var review = (from R in _db.Genres
                        select new Reviews
                        {
                            Id = R.Id,
                        }).ToList();
            
            return review;
        }

        public void WriteAuthor(Reviews review)
        {
            _db.Add(review);
            _db.SaveChanges();
        }
    }
}