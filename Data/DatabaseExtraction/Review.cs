using System;

namespace BookCave.Data.DatabaseExtraction
{
    public class Review
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public double Rating { get; set; }
        public DateTime Date { get; set; }
        public int PositiveScore { get; set; } 
        public int NegativeScore { get; set; }
    }
}