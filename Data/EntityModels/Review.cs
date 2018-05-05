using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Models;
using BookCave.Data.EntityModels;


namespace BookCave.Data.EntityModels
{
    public class Review
    {
        public int Id { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Book Book {get;set;}
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual AspNetUsers User{get;set;}
        public string Text { get; set; }
        public double Rating { get; set; }
        public DateTime Date { get; set; }
        public int PositiveScore { get; set; }
        public int NegativeScore { get; set; }
    }
}