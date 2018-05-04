namespace BookCave.Data.EntityModels
{
    public class ShippingAddress
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country {get; set; }
        public string StateOrProvince { get; set; }
        public string Zip { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
    }
}