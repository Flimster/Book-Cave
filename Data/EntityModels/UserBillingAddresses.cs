using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class UserBillingAddresses
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public virtual BillingAddress Address { get; set; }
        
        #region NavigationProperties
        public virtual List<BillingAddress> Reviews { get; set; }
        //public Review Reviews { get; set; }
        #endregion
    }
}