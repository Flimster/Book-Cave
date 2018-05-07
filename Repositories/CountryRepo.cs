using System;
using System.Collections.Generic;
using BookCave.Data.EntityModels;
using BookCave.Data;

namespace BookCave.Repositories
{
    public class CountryRepo
    {
        private DataContext _db;

        public CountryRepo()
        {
            _db = new DataContext();
        }

        public List<Country> GetCountryList()
        {
            var country = (from C in _db.Country
                        select new Country
                        {
                            Id = C.Id,
                            Name = C.Name
                        }).ToList();
            
            return country;
        }

        public void WriteCountry(Country country)
        {
            _db.Add(country);
            _db.SaveChanges();
        }
    }
}