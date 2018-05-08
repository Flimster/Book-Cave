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

        public List<Countries> GetList()
        {
            var country = (from C in _db.Countries
                        select new Countries
                        {
                            Id = C.Id,
                            Name = C.Name
                        }).ToList();
            
            return country;
        }

        public void Write(Countries country)
        {
            _db.Add(country);
            _db.SaveChanges();
        }

        public void Remove(Countries country)
        {
            _db.Remove(country);
            _db.SaveChanges();
        }
    }
}