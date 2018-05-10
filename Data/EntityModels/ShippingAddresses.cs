using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class ShippingAddresses
    {
        public int Id { get; set; }
        [ForeignKey("Countries")]
        public int CountriesId { get; set; }
        public virtual Countries Countries {get; set; }
        public string StateOrProvince { get; set; }
        public string Zip { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
    }
}