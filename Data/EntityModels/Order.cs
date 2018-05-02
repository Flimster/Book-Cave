using System;
using System.Collections.Generic;

namespace Book_Cave.Data.EntityModels
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
        public double OrderPrice { get; set; }
        public List<int> BooksId { get; set; }
        public int ShippingAddressId { get; set; }
        public int BillingAddressId { get; set; }
        public int CardDetailsId { get; set; }
    }
}