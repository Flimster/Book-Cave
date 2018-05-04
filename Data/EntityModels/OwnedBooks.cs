using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class OwnedBooks
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public AspNetUsers User { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}