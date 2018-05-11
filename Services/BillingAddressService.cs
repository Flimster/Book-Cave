using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
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

        public List<BillingAddressViewModel> GetList()
        {
            return _billingAddressRepo.GetList();
        }

        public void Write(BillingAddressViewModel address)
        {
            _billingAddressRepo.Write(address);
        }

        public void Edit(int addressId, BillingAddresses address)
        {
            _billingAddressRepo.Edit(addressId, address);
        }

        public List<BillingAddressViewModel> GetByUserId(string Id)
        {
            return _billingAddressRepo.GetByUserId(Id);
        }
    }
}