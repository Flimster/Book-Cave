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

<<<<<<< HEAD
        public void WriteAuthor(Genres genre)
=======
        public void WriteGenre(Genre genre)
>>>>>>> 6503106af5a1734b4794bd6fa33275decd132fea
        {
            _db.Add(genre);
            _db.SaveChanges();
        }
    }
}