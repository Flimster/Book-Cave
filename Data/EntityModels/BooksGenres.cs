using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class BooksGenres
    {
        public int Id { get; set; }
        [ForeignKey("Genres")]
        public int GenreId { get; set; }
        public virtual Genres Genres { get; set; }
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public virtual Books Books { get; set; }
    }
}