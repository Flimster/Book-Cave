using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace Book_Cave.Repositories
{
    public class FeedbackRepo
    {
        private DataContext _db;

        public FeedbackRepo()
        {
            _db = new DataContext();
        }

        public List<Feedbacks> GetList()
        {
            var feedback = (from F in _db.Feedbacks
                        select new Feedbacks
                        {
                            Id = F.Id,
                            //Missing query for users and more
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