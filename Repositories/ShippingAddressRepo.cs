using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;
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

        public List<ShippingAddressViewModel> GetByUserId(string UserId)
        {
            var shippingAddresses = 
                (from UsBi in _db.UsersShippingAddresses
                join Shi in _db.ShippingAddresses on UsBi.AddressId equals Shi.Id
                where UsBi.AspNetUserId == UserId
                select new ShippingAddressViewModel
                {
                    Id = Shi.Id,
                    Country =
                        (from C in _db.Countries
                        where Shi.CountryId == C.Id
                        select C.Name).FirstOrDefault(),
                    StateOrProvince = Shi.StateOrProvince,
                    City = Shi.City,
                    Zip = Shi.Zip,
                    StreetAddress = Shi.StreetAddress
                }).ToList();
            return shippingAddresses;
        }

        public List<ShippingAddressViewModel> GetByAddressId(int addressId)
        {
            var shippingAddresses = 
                (from UsBi in _db.UsersShippingAddresses
                join Shi in _db.ShippingAddresses on UsBi.AddressId equals Shi.Id
                where UsBi.AddressId== addressId
                select new ShippingAddressViewModel
                {
                    Id = Shi.Id,
                    Country =
                        (from C in _db.Countries
                        where Shi.CountryId == C.Id
                        select C.Name).FirstOrDefault(),
                    StateOrProvince = Shi.StateOrProvince,
                    City = Shi.City,
                    Zip = Shi.Zip,
                    StreetAddress = Shi.StreetAddress
                }).ToList();
            return shippingAddresses;
        }

        public void Edit(int addressId, ShippingAddresses address)
        {
            var shippingAddress =
                from Bil in _db.ShippingAddresses
                where Bil.Id == addressId
                select Bil;

                foreach(ShippingAddresses ship in shippingAddress)
                {
                    ship.City = address.City;
                    ship.Zip = address.Zip;
                    ship.CountryId = address.CountryId;
                    ship.StateOrProvince = address.StateOrProvince;
                    ship.StreetAddress = address.StreetAddress;
                }
                _db.SaveChanges();
        }

        public void Write(ShippingAddresses shippingAddress)
        {
            _db.Add(shippingAddress);
            _db.SaveChanges();
        }

        public void Remove(ShippingAddresses shippingAddress)
        {
            _db.Remove(shippingAddress);
            _db.SaveChanges();
        }
    }
}