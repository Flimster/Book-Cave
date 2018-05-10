using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class UserBookRating
    {
        public int Id { get; set; }
        [ForeignKey("AspNetUsers")]
        public string AspNetUsersId { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public Books Books { get; set; }
    }
}