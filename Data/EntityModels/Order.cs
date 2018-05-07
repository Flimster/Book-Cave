using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Models;
using BookCave.Data.EntityModels;


namespace BookCave.Data.EntityModels
{
    public class Order
    {
        public int Id { get; set; }
        [ForeignKey("AspNetUsers")]
        public string AspNetUsersId { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
        public double OrderPrice { get; set; }
        [ForeignKey("ShippingAddress")]
        public int ShippingAddressId { get; set; }
        public virtual ShippingAddress ShippingAddress { get; set; }
        [ForeignKey("BillingAddress")]
        public int BillingAddressId { get; set; }
        public virtual BillingAddress BillingAddress { get; set; }
        [ForeignKey("CardDetails")]
        public int CardDetailsId { get; set; }
        public virtual CardDetails CardDetails { get; set; }     
    }
}