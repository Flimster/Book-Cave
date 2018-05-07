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

<<<<<<< HEAD
        public void WriteAuthor(BillingAddresses billingAddress)
=======
        public void WriteBillingAddress(BillingAddress billingAddress)
>>>>>>> 6503106af5a1734b4794bd6fa33275decd132fea
        {
            _db.Add(billingAddress);
            _db.SaveChanges();
        }
    }
}