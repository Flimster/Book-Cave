using System;

namespace BookCave.Models.ViewModels
{
    public class ReviewViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Book { get; set; }
        public string Text { get; set; }
        public double Rating { get; set; }
        public DateTime Date { get; set; }
        public int PositiveScore { get; set; }
        public int NegativeScore { get; set; }
        public bool Edited { get; set; }
    }
}