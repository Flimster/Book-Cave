using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace BookCave.Repositories
{
    public class ReviewRepo
    {
        private AuthenticationDbContext _db;

        public ReviewRepo()
        {
           // _db = new DataContext();
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

<<<<<<< HEAD
        public void WriteAuthor(Reviews review)
=======
        public void WriteReview(Review review)
>>>>>>> 6503106af5a1734b4794bd6fa33275decd132fea
        {
            _db.Add(review);
            _db.SaveChanges();
        }
    }
}