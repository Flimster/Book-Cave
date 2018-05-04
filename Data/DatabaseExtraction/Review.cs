using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class Review
    {
        public int Id { get; set; }
        [ForeignKey("BkId")]
        public int BookId { get; set; }
        public Book BkId {get; set;}
        [ForeignKey("UsrId")]
        public int UserId { get; set; }
        public UserAccount UsrId { get; set; }
        public string Text { get; set; }
        public double Rating { get; set; }
        public DateTime Date { get; set; }
        public int PositiveScore { get; set; } 
        public int NegativeScore { get; set; }
    }
}