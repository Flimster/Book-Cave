using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class BookGenre
    {
        public int Id { get; set; }
        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}