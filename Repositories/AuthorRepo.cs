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

        public List<Author> GetAuthorList()
        {
            var authors = (from A in _db.Author
                        select new Author
                        {
                            Id = A.Id,
                            Name = A.Name,
                        }).ToList();
            
            return authors;
        }

        public void WriteAuthor(List<Author> author)
        {
            _db.AddRange(author);
            _db.SaveChanges();
        }
    }
}