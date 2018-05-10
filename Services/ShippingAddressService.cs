using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using BookCave.Repositories;

namespace BookCave.Services
{
    public class ShippingAddressService
    {
        private ShippingAddressRepo _shippingAddressRepo;

        private DataContext _db;

        public ShippingAddressService()
        {
            _shippingAddressRepo = new ShippingAddressRepo();
            _db = new DataContext();
        }

        public List<ShippingAddressViewModel> GetList()
        {
            return _shippingAddressRepo.GetList();
        }

        public List<ShippingAddressViewModel> GetByUserId(string UserId)
        {
            return _shippingAddressRepo.GetByUserId(UserId);
        }
    }
}