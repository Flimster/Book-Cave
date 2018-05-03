using System;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class Orders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStatus { get; set; }
        public double OrderPrice { get; set; }
        public int ShippingAddressId { get; set; }
        public int BillingAddressId { get; set; }
        public int CardDetailsId { get; set; }
    }
}