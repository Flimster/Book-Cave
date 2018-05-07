using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class UserReviews
    {
        public int Id { get; set; }
        [ForeignKey("AspNetUsers")]
        public string AspNetUsersId { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
        [ForeignKey("Review")]
        public int ReviewId { get; set; }
        public virtual Review Review { get; set; }
    }
}