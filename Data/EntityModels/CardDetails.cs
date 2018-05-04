using System;

namespace BookCave.Data.EntityModels
{
    public class CardDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CardNumber { get; set; }
        public int Cvc { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}