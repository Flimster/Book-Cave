using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using BookCave.Repositories;

namespace BookCave.Services
{
    public class BillingAddressService
    {
        private BillingAddressRepo _billingAddressRepo;

        private DataContext _db;

        public BillingAddressService()
        {
            _billingAddressRepo = new BillingAddressRepo();
            _db = new DataContext();
        }

        public List<BillingAddressesViewModel> GetList()
        {
            return _billingAddressRepo.GetList();
        }

        public List<BillingAddressesViewModel> GetByUserId(string Id)
        {
            return _billingAddressRepo.GetByUserId(Id);
        }
    }
}