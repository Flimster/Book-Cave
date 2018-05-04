using System;

namespace BookCave.Data.EntityModels
{
    public class Feedback
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}