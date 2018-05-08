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

        public List<Reviews> GetList()
        {
            var review = (from R in _db.Genres
                        select new Reviews
                        {
                            Id = R.Id,
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