using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class UserCard
    {
        public int Id { get; set; }
        [ForeignKey("UsrId")]
        public int UserId { get; set; }
        public UserAccount UsrId { get; set; }
        [ForeignKey("CrdId")]
        public int CardDetailsId { get; set; }
        public CardDetails CrdId { get; set; }
    }
}