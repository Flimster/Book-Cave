namespace BookCave.Data.DatabaseExtraction
{
    public class Address
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Zip { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
    }
}