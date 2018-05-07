using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }	
        public int ReleaseYear { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }       //////////// Rating Rating
        public string ISBN10 { get; set; }
        public string ISBN13 { get; set; }
        public int StockCount { get; set; }
        public bool Visibility { get; set; }
        public virtual Formats BookFormat { get; set; }
        public string Image { get; set; }
        public string Publisher { get; set; }
    }
}