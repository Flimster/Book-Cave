using System;
using System.Collections.Generic;

namespace BookCave.Data.EntityModels
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
        public double OrderPrice { get; set; }
        public int ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }
        public int BillingAddressId { get; set; }
        public Address BillingAddress { get; set; }
        public int CardDetailsId { get; set; }
        public CardDetails CardDetails { get; set; }

        #region NavigationProperties
        public List<Book> BooksId { get; set; }
        public Book Books { get; set; }
        #endregion       
    }
}