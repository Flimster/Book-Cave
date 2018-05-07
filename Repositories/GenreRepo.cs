using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace BookCave.Repositories
{
    public class GenreRepo
    {
        private DataContext _db;

        public GenreRepo()
        {
            _db = new DataContext();
        }

        public List<Genre> GetGenreList()
        {
            var genre = (from G in _db.Genre
                        select new Genre
                        {
                            Id = G.Id,
                            Name = G.Name
                        }).ToList();
            
            return genre;
        }

        public void WriteAuthor(Genre genre)
        {
            _db.Add(genre);
            _db.SaveChanges();
        }
    }
}