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

        public List<ShippingAddresses> GetList()
        {
            var shippingAddress = (from S in _db.ShippingAddresses
                        select new ShippingAddresses
                        {
                            Id = S.Id,
                            CountryId = S.CountryId,
                            Countries = S.Countries,
                            StateOrProvince = S.StateOrProvince,
                            City = S.City,
                        }).ToList();
            
            return shippingAddress;
        }

        public void Write(ShippingAddresses shippingAddress)
        {
            _db.Add(shippingAddress);
            _db.SaveChanges();
        }

        public void Remove(ShippingAddresses addr)
        {
            _db.Remove(addr);
            _db.SaveChanges();
        }
    }
}