using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Models;
using BookCave.Data.EntityModels;
using Microsoft.AspNetCore.Identity;


namespace BookCave.Data.EntityModels
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
        public double OrderPrice { get; set; }
       // [ForeignKey("ShippingAddress")]
        public int ShippingAddressId { get; set; }
        //public virtual ShippingAddress ShippingAddress { get; set; }
        //[ForeignKey("BillingAddress")]
        public int BillingAddressId { get; set; }
       // public virtual BillingAddress BillingAddress { get; set; }
        //[ForeignKey("CardDetails")]
        public int CardDetailsId { get; set; }
        //public virtual CardDetails CardDetails { get; set; } 
        public int OrderBooksId { get; set; }
    }
}