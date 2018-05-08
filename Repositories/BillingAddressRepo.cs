using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace BookCave.Repositories
{
    public class BillingAddressRepo
    {
        private AuthenticationDbContext _db;

        public BillingAddressRepo()
        {
            //_db = new DataContext();
        }

        public List<BillingAddresses> GetBillingAddressList()
        {
            var billingAddresses = (from B in _db.BillingAddress
                        select new BillingAddresses
                        {
                            Id = B.Id,
                            CountryId = B.CountryId,
                            Countries = B.Countries,
                            StateOrProvince = B.StateOrProvince,
                            City = B.City,
                        }).ToList();
            
            return billingAddresses;
        }

        public void WriteBillingAddress(BillingAddresses billingAddress)
        {
            _db.Add(billingAddress);
            _db.SaveChanges();
        }
    }
}