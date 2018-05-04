using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class BookLanguage
    {
        public int Id { get; set; }
        [ForeignKey("BkId")]
        public int BookId { get; set; }
        public Book BkId {get; set;}
        [ForeignKey("LangId")]
        public int LanguageId { get; set; }
        public Language LangId {get; set;}
    }
}