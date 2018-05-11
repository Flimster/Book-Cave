using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;
using BookCave.Models.ViewModels;

namespace BookCave.Repositories
{
    public class BillingAddressRepo
    {
        private DataContext _db;

        public BillingAddressRepo()
        {
            _db = new DataContext();
        }
        public List<BillingAddressViewModel> GetByUserId(string UserId)
        {
            var billingAddresses = 
                (from UsBi in _db.UserBillingAddresses
                join Bil in _db.BillingAddress on UsBi.AddressId equals Bil.Id
                where UsBi.AspNetUserId == UserId
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

        public void Write(BillingAddressViewModel billingAddress)
        {
            _db.Add(billingAddress);
            _db.SaveChanges();
        }

        public void Remove(BillingAddressViewModel address)
        {
            _db.Remove(address);
            _db.SaveChanges();
        }

        public void Edit(int addressId, BillingAddresses address)
        {
            var billingAddress =
                from Bil in _db.BillingAddress
                where Bil.Id == addressId
                select Bil;

                foreach(BillingAddresses bil in billingAddress)
                {
                    bil.City = address.City;
                    bil.Zip = address.Zip;
                    bil.CountryId = address.CountryId;
                    bil.StateOrProvince = address.StateOrProvince;
                    bil.StreetAddress = address.StreetAddress;
                }
                _db.SaveChanges();
        }
    }
}