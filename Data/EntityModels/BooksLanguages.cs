using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class BooksLanguages
    {
        public int Id { get; set; }
        [ForeignKey("Languages")]
        public int LanguageId {get; set;}
        public virtual Languages Languages { get; set; }
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public virtual Books Books { get; set; }
    }
}