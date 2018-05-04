using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class Feedback
    {
        public int Id { get; set; }
        public int FeedbackType { get; set; }
        public string Text { get; set; }
        [ForeignKey("UsrId")]
        public int UserId { get; set; }
        public UserAccount UsrId { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
    }
}