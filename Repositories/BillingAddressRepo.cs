using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;
using BookCave.Models.ViewModels;

namespace BookCave.Repositories
{
    public class BillingAddressRepo
    {
        private UserBillingAddresses _userBillingAddresses;
        private BillingAddressViewModel _billingAddressView;
        private DataContext _db;

        public BillingAddressRepo()
        {
            _db = new DataContext();
            _userBillingAddresses = new UserBillingAddresses();
            _billingAddressView = new BillingAddressViewModel();
        }
        public List<BillingAddressViewModel> GetByUserId(string userId)
        {
            var billingAddresses = 
                (from UsBi in _db.UserBillingAddresses
                join Bil in _db.BillingAddress on UsBi.AddressId equals Bil.Id
                where UsBi.AspNetUserId == userId
                select new BillingAddressViewModel
                {
                    Id = Bil.Id,
                    Country =
                        (from C in _db.Countries
                        where Bil.CountryId == C.Id
                        select C.Name).FirstOrDefault(),
                    StateOrProvince = Bil.StateOrProvince,
                    City = Bil.City,
                    Zip = Bil.Zip,
                    StreetAddress = Bil.StreetAddress
                }).ToList();
            return billingAddresses;
        }

        public BillingAddressViewModel GetByAddressId(int addressId)
        {
            var billingAddresses = 
                (from UsBi in _db.UserBillingAddresses
                join Bil in _db.BillingAddress on UsBi.AddressId equals Bil.Id
                where UsBi.AddressId == addressId
                select new BillingAddressViewModel
                {
                    Id = Bil.Id,
                    Country =
                        (from C in _db.Countries
                        where Bil.CountryId == C.Id
                        select C.Name).SingleOrDefault(),
                    StateOrProvince = Bil.StateOrProvince,
                    City = Bil.City,
                    Zip = Bil.Zip,
                    StreetAddress = Bil.StreetAddress
                }).SingleOrDefault();
            return billingAddresses;
        }

        public void WriteMiddleTable(string UserId, BillingAddresses BillingAddress) {
            var adr = GetByUserId(UserId).LastOrDefault();
            _userBillingAddresses.AddressId = adr.Id;
            _userBillingAddresses.AspNetUserId = UserId;
            _db.Add(_userBillingAddresses);
            _db.SaveChanges();
        }

        public void Write(string UserId, BillingAddresses BillingAddress)
        {
            _userBillingAddresses.AddressId = BillingAddress.Id;   
            _db.Add(BillingAddress);
            WriteMiddleTable(UserId, BillingAddress);
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