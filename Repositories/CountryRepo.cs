using System;
using System.Collections.Generic;
using BookCave.Data.EntityModels;
using BookCave.Data;
using System.Linq;

namespace BookCave.Repositories
{
    public class CountryRepo
    {
        private DataContext _db;

        public CountryRepo()
        {
            _db = new DataContext();
        }

        public List<Countries> GetCountryList()
        {
            var country = (from C in _db.Countries
                        select new Countries
                        {
                            Id = C.Id,
                            Name = C.Name
                        }).ToList();
            
            return country;
        }

        public void WriteCountry(Countries country)
        {
            _db.Add(country);
            _db.SaveChanges();
        }
    }
}