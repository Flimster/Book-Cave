using System;
using System.Collections.Generic;

namespace BookCave.Data.EntityModels
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
        public double OrderPrice { get; set; }
        public List<int> BooksId { get; set; }
        public Book Book { get; set; }
        public int ShippingAddressId { get; set; }
        public Address sAddress { get; set; }
        public int BillingAddressId { get; set; }
        public Address bAddress { get; set; }
        public int CardDetailsId { get; set; }
        public CardDetails CardDetails { get; set; }
    }
}