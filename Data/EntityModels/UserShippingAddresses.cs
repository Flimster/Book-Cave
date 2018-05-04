using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Models.ViewModels;

namespace BookCave.Data.EntityModels
{
    public class UserShippingAddresses
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public virtual ShippingAddress Address { get; set; }

        #region NavigationProperties
        public virtual List<ShippingAddress> ListAddress { get; set; }
        //public Review Reviews { get; set; }
        #endregion
    }
}