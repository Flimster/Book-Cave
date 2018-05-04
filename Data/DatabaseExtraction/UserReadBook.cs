using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class UserReadBook
    {
        public int Id { get; set; }
        [ForeignKey("UsrId")]
        public int UserId { get; set; }
        public UserAccount UsrId { get; set; }
        [ForeignKey("BkId")]
        public int BookId { get; set; }
        public Book BkId {get; set;}
    }
}