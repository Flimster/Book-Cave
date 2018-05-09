using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using BookCave.Repositories;

namespace BookCave.Services
{
    public class BillingAddressService
    {
        private BillingAddressRepo _billingAddressRepo;
        private CountryRepo _countryRepo;

        private DataContext _db;

        public BillingAddressService()
        {
            _billingAddressRepo = new BillingAddressRepo();
            _countryRepo = new CountryRepo();
            _db = new DataContext();
        }

        public List<BillingAddressesViewModel> GetList()
        {
            return _billingAddressRepo.GetList();
        }
    }
}