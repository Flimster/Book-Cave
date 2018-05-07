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

        public List<Feedback> GetFeedbackList()
        {
            var feedback = (from F in _db.Feedback
                        select new Feedback
                        {
                            Id = F.Id,
                            //Missing query for users and more
                        }).ToList();
            
            return feedback;
        }

        public void WriteFeedback(Feedback feedback)
        {
            _db.Add(feedback);
            _db.SaveChanges();
        }
    }
}