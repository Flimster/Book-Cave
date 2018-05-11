using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using BookCave.Repositories;

namespace BookCave.Services
{
    public class CountryService
    {
        private CountryRepo _countryRepo;

        private DataContext _db;

        public CountryService()
        {
            _countryRepo = new CountryRepo();
            _db = new DataContext();
        }

        public List<Countries> GetList()
        {
            return _countryRepo.GetList();
        }

        public void Write(Countries country)
        {
            _countryRepo.Write(country);
        }

        public void Remove(Countries country)
        {
            _countryRepo.Remove(country);
        }
    }
}