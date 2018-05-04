using System;

namespace BookCave.Data.DatabaseExtraction
{
    public class CardDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CardNumber { get; set; }
        public int CVC { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}