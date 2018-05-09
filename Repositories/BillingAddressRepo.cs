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
                            Country = (from C in _db.Countries
                                       where B.CountryId == C.Id
                                       select C.Name).SingleOrDefault(),
                            StateOrProvince = B.StateOrProvince,
                            City = B.City,
                            Zip = B.Zip
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