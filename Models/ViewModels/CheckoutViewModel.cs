using System.Collections.Generic;

namespace BookCave.Models.ViewModels
{
    public class CheckoutViewModel
    {
        public List<ShippingAddressViewModel> ShippingAddresses { get; set; }
        public List<BillingAddressViewModel> BillingAddresses { get; set; }
        public List<CardDetailsViewModel> Cards { get; set; }
        public ShippingAddressViewModel SelectedShipping { get; set; }
        public BillingAddressViewModel SelectedBilling { get; set; }
        public CardDetailsViewModel SelectedCard { get; set; }
        public int CurrentStatus { get; set; }
        public CartViewModel Order { get; set; }
        public string AspNetUserId { get; set; }
    }
}