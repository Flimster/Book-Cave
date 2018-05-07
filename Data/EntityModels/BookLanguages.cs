using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class BookLanguages
    {
        public int Id { get; set; }
        [ForeignKey("Language")]
        public int LanguageId {get; set;}
        public virtual Language Language { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}