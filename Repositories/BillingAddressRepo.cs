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

        public List<BillingAddressesViewModel> GetList()
        {
            var billingAddresses = (from B in _db.BillingAddress
                        select new BillingAddressesViewModel
                        {
                            Id = B.Id,
                            Country = 
                                (from C in _db.Countries
                                where B.CountryId == C.Id
                                select C.Name).FirstOrDefault(),
                            StateOrProvince = B.StateOrProvince,
                            City = B.City,
                            Zip = B.Zip
                        }).ToList();
            
            return billingAddresses;
        }

        public List<BillingAddressesViewModel> GetByUserId(string UserId)
        {
            var billingAddresses = 
                (from UsBi in _db.UserBillingAddresses
                join Bil in _db.BillingAddress on UsBi.AddressId equals Bil.Id
                where UsBi.AspNetUsersId == UserId
                select new BillingAddressesViewModel
                {
                    Id = Bil.Id,
                    Country =
                        (from C in _db.Countries
                        where Bil.CountryId == C.Id
                        select C.Name).FirstOrDefault(),
                    StateOrProvince = Bil.StateOrProvince,
                    City = Bil.City,
                    Zip = Bil.Zip
                }).ToList();
            return billingAddresses;
        }

        public void Write(BillingAddresses billingAddress)
        {
            _db.Add(billingAddress);
            _db.SaveChanges();
        }

        public void Remove(BillingAddresses address)
        {
            _db.Remove(address);
            _db.SaveChanges();
        }
    }
}