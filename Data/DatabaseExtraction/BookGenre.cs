using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class BookGenre
    {
        public int Id { get; set; }
        [ForeignKey("BkId")]
        public int BookId { get; set; }
        public Book BkId {get; set;}
        [ForeignKey("GnrId")]
        public int GenreId { get; set; }
        public Genre GnrId {get; set;}
    }
}