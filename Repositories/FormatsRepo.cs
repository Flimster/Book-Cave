using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace BookCave.Repositories
{
    public class FormatsRepo
    {
        private AuthenticationDbContext _db;

        public FormatsRepo()
        {
            //_db = new DataContext();
        }

        public List<Formats> GetBookList()
        {
            var Authors = (from A in _db.Formats
                        select new Formats
                        {
                            Id = A.Id,
                            Name = A.Name,
                        }).ToList();
            
            return Authors;
        }

        public void WriteAuthor(List<Formats> formats)
        {
            _db.AddRange(formats);
            _db.SaveChanges();
        }
    }
}