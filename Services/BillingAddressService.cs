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
        public void Write(BillingAddressViewModel billingAddress)
        {
            _billingAddressRepo.Write(billingAddress);
        }

        public void Edit(int addressId, BillingAddresses billingAddress)
        {
            _billingAddressRepo.Edit(addressId, billingAddress);
        }

        public List<BillingAddressViewModel> GetByUserId(string userId)
        {
            return _billingAddressRepo.GetByUserId(userId);
        }

        public BillingAddressViewModel GetByAddressId(int addressId)
        {
            return _billingAddressRepo.GetByAddressId(addressId);
        }
    }
}