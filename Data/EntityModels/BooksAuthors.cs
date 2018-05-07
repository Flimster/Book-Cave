using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class BooksAuthors
    {
        public int Id { get; set; }
        [ForeignKey("Authors")]
        public int AuthorId { get; set; }
        public virtual Authors Authors { get; set; }
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public virtual Books Books { get; set; }
    }
}