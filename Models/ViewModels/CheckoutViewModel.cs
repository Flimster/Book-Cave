using System.Collections.Generic;

namespace BookCave.Models.ViewModels
{
    public class CheckoutViewModel
    {
        public List<ShippingAddressViewModel> ShippingAddresses { get; set; }
        public List<BillingAddressViewModel> BillingAddresses { get; set; }
        public List<CardDetailsView> Cards { get; set; }
        public ShippingAddressViewModel SelectedShipping { get; set; }
        public BillingAddressViewModel SelectedBilling { get; set; }
        public CardDetailsView SelectedCard { get; set; }
        public int CurrentStatus { get; set; }
    }
}