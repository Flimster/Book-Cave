using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class BillingAddress

    {
        public int Id { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public virtual Country Country {get; set; }
        public string StateOrProvince { get; set; }
        public string Zip { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
    }
}