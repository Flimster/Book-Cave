using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;
using Book_Cave.Models.ViewModels;
using BookCave.Models.ViewModels;

namespace BookCave.Repositories
{
    public class ShippingAddressRepo
    {
         private DataContext _db;

        public ShippingAddressRepo()
        {
            _db = new DataContext();
        }

        public List<ShippingAddressViewModel> GetList()
        {
            var shippingAddress = (from S in _db.ShippingAddresses
                        select new ShippingAddressViewModel
                        {
                            Id = S.Id,
                            Country = 
                                (from C in _db.Countries
                                where S.Id == C.Id
                                select C.Name).FirstOrDefault(),
                            StateOrProvince = S.StateOrProvince,
                            City = S.City,
                        }).ToList();
            
            return shippingAddress;
        }

        public List<ShippingAddressViewModel> GetByUserId(string UserId)
        {
            var shippingAddresses = 
                (from UsBi in _db.UserBillingAddresses
                join Bil in _db.BillingAddress on UsBi.AddressId equals Bil.Id
                where UsBi.AspNetUsersId == UserId
                select new ShippingAddressViewModel
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
            return shippingAddresses;
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