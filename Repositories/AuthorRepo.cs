using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace BookCave.Repositories
{
    public class AuthorRepo
    {
        private DataContext _db;

        public AuthorRepo()
        {
            _db = new DataContext();
        }

        public List<Authors> GetAuthorList()
        {
            var authors = (from A in _db.Authors
                        select new Authors
                        {
                            Id = A.Id,
                            Name = A.Name,
                        }).ToList();
            
            return authors;
        }

        public void WriteAuthor(List<Authors> author)
        {
            _db.AddRange(author);
            _db.SaveChanges();
        }
    }
}