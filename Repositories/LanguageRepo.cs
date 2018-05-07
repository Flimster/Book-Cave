using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace BookCave.Repositories
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
            var languages = (from L in _db.Language
                        select new Language
                        {
                            Id = L.Id,
                            Name = L.Name,
                        }).ToList();
            
            return languages;
        }

        public void WriteAuthor(Language language)
        {
            _db.Add(language);
            _db.SaveChanges();
        }
    }
}