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

        public List<Language> GetLanguageList()
        {
            var language = (from L in _db.Genre
                        select new Language
                        {
                            Id = L.Id,
                            Name = L.Name
                        }).ToList();
            
            return language;
        }

        public void WriteLanguage(Language language)
        {
            _db.Add(language);
            _db.SaveChanges();
        }
    }
}