using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;
using BookCave.Models.ViewModels;

namespace BookCave.Repositories
{
    public class BillingAddressRepo
    {
        private BillingAddressViewModel _billingAddressView;
        private DataContext _db;

        public BillingAddressRepo()
        {
            _db = new DataContext();
            _billingAddressView = new BillingAddressViewModel();
        }
        public BillingAddressViewModel GetByAddressId(int addressId)
        {
            var billingAddresses = 
                (from Bi in _db.BillingAddress
                where Bi.Id == addressId
                select new BillingAddressViewModel
                {
                    Id = Bi.Id,
                    AspNetUserId = Bi.AspNetUserId,
                    Country =
                        (from C in _db.Countries
                        where Bi.CountryId == C.Id
                        select C.Name).SingleOrDefault(),
                    StateOrProvince = Bi.StateOrProvince,
                    City = Bi.City,
                    Zip = Bi.Zip,
                    StreetAddress = Bi.StreetAddress
                }).SingleOrDefault();
            return billingAddresses;
        }


        public List<BillingAddressViewModel> GetByUserId(string userId)
        {
            var billingAddresses = 
                (from Bi in _db.BillingAddress
                where Bi.AspNetUserId == userId
                select new BillingAddressViewModel
                {
                    Id = Bi.Id,
                    Country =
                        (from C in _db.Countries
                        where Bi.CountryId == C.Id
                        select C.Name).FirstOrDefault(),
                    StateOrProvince = Bi.StateOrProvince,
                    City = Bi.City,
                    Zip = Bi.Zip,
                    StreetAddress = Bi.StreetAddress
                } ).ToList();

            return billingAddresses;
        }
        public void Write(BillingAddresses BillingAddress)
        {
            _db.Add(BillingAddress);
            _db.SaveChanges();
        }

        public void Remove(BillingAddresses billingAddress)
        {
            _db.Remove(billingAddress);
            _db.SaveChanges();
        }

        public void Edit(int addressId, BillingAddresses billingAddress)
        {
            var address =
                from Bil in _db.BillingAddress
                where Bil.Id == addressId
                select Bil;

                foreach(BillingAddresses bil in address)
                {
                    bil.City = billingAddress.City;
                    bil.Zip = billingAddress.Zip;
                    bil.CountryId = billingAddress.CountryId;
                    bil.StateOrProvince = billingAddress.StateOrProvince;
                    bil.StreetAddress = billingAddress.StreetAddress;
                }
                _db.SaveChanges();
        }
    }
}