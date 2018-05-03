using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class Address
    {
        public int Id { get; set; }
        [ForeignKey("Count")]
        public int CountryId { get; set; }
        public Country Count {get; set;}
        public string Zip { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
    }
}