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
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public double Price { get; set; }
        [ForeignKey("ShippingAddresses")]
        public int ShippingAddressesId { get; set; }
        public virtual ShippingAddresses BillingAdShippingAddressesdresses { get; set; }
        [ForeignKey("BillingAddresses")]
        public int BillingAddressesId { get; set; }
        public virtual BillingAddresses BillingAddresses { get; set; }
        [ForeignKey("CardDetails")]
        public int CardDetailsId { get; set; }
        public virtual CardDetails CardDetails { get; set; } 
    }
}