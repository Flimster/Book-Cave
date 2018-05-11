using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace Book_Cave.Repositories
{
    public class LanguageRepo
    {
        private DataContext _db;

        public LanguageRepo()
        {
            _db = new DataContext();
        }

        public List<Languages> GetList()
        {
            var language = 
                (from L in _db.Genres
                select new Languages
                {
                    Id = L.Id,
                    Name = L.Name
                }).ToList();
            return language;
        }

        public void Write(Languages language)
        {
            _db.Add(language);
            _db.SaveChanges();
        }

        public void Remove(Languages language)
        {
            _db.Remove(language);
            _db.SaveChanges();
        }
    }
}