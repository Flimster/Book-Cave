using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace BookCave.Repositories
{
    public class GenreRepo
    {
        private AuthenticationDbContext _db;

        public GenreRepo()
        {
            //_db = new DataContext();
        }

        public List<Genres> GetGenreList()
        {
            var genre = (from G in _db.Genres
                        select new Genres
                        {
                            Id = G.Id,
                            Name = G.Name
                        }).ToList();
            
            return genre;
        }

        public void WriteAuthor(Genres genre)
        {
            _db.Add(genre);
            _db.SaveChanges();
        }
    }
}