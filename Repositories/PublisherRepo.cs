using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace BookCave.Repositories
{
    public class PublisherRepo
    {
        private DataContext _db;

        public PublisherRepo()
        {
            _db = new DataContext();
        }

        public List<Publisher> GetPublisherList()
        {
            var publisher = (from A in _db.Publisher
                        select new Publisher
                        {
                            Id = A.Id,
                            Name = A.Name,
                        }).ToList();
            
            return publisher;
        }

        public void WriteAuthor(List<Formats> formats)
        {
            _db.AddRange(formats);
            _db.SaveChanges();
        }
    }
}