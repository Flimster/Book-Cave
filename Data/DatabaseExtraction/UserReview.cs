using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class UserReview
    {
        public int Id { get; set; }
        [ForeignKey("UsrId")]
        public int UserId { get; set; }
        public UserAccount UsrId { get; set; }
        [ForeignKey("RevId")]
        public int ReviewId { get; set; }
        public Review RevId { get; set; }
    }
}