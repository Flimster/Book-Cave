using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace BookCave.Repositories
{
    public class ShippingAddressRepo
    {
         private DataContext _db;

        public ShippingAddressRepo()
        {
            _db = new DataContext();
        }

        public List<ShippingAddress> GetShippingAddressList()
        {
            var shippingAddress = (from S in _db.ShippingAddress
                        select new ShippingAddress
                        {
                            Id = S.Id,
                            CountryId = S.CountryId,
                            Country = S.Country,
                            StateOrProvince = S.StateOrProvince,
                            City = S.City,
                        }).ToList();
            
            return shippingAddress;
        }

        public void WriteAuthor(ShippingAddress shippingAddress)
        {
            _db.Add(shippingAddress);
            _db.SaveChanges();
        }
    }
}