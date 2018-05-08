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

        public List<Genres> GetList()
        {
            var genre = (from G in _db.Genres
                        select new Genres
                        {
                            Id = G.Id,
                            Name = G.Name
                        }).ToList();
            
            return genre;
        }

        public void Write(Genres genre)
        {
            _db.Add(genre);
            _db.SaveChanges();
        }

        public void Remove(Genres genre)
        {
            _db.Remove(genre);
            _db.SaveChanges();
        }
    }
}