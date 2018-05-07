using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace BookCave.Repositories
{
    public class BillingAddressRepo
    {
        private DataContext _db;

        public BillingAddressRepo()
        {
            _db = new DataContext();
        }

        public List<BillingAddress> GetBillingAddressList()
        {
            var billingAddresses = (from B in _db.BillingAddress
                        select new BillingAddress
                        {
                            Id = B.Id,
                            CountryId = B.CountryId,
                            Country = B.Country,
                            StateOrProvince = B.StateOrProvince,
                            City = B.City,
                        }).ToList();
            
            return billingAddresses;
        }

        public void WriteAuthor(BillingAddress billingAddress)
        {
            _db.Add(billingAddress);
            _db.SaveChanges();
        }
    }
}