using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class BookReview
    {
        public int Id { get; set; }
        [ForeignKey("BkId")]
        public int BookId { get; set; }
        public Book BkId {get; set;}
        [ForeignKey("RevId")]
        public int ReviewId { get; set; }
        public Review RevId {get; set;}
    }
}