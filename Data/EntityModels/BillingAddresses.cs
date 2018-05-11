using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class BillingAddresses

    {
        public int Id { get; set; }
        [ForeignKey("Countries")]
        public int CountryId { get; set; }
        public virtual Countries Countries {get; set; }
        [ForeignKey("AspNetUsers")]
        public string AspNetUserId { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
        public string StateOrProvince { get; set; }
        public string Zip { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
    }
}