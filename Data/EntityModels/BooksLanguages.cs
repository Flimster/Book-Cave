using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class BooksLanguages
    {
        public int Id { get; set; }
        [ForeignKey("Language")]
        public int LanguageId {get; set;}
        public virtual Languages Language { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Books Book { get; set; }
    }
}