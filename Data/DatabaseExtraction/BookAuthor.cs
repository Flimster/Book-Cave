using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class BookAuthor
    {
        public int Id { get; set; }
        [ForeignKey("BkId")]
        public int BookId { get; set; }
        public Book BkId {get; set;}
        [ForeignKey("AuthId")]
        public int AuthorId { get; set; }
        public Author AuthId {get; set;}
    }
}