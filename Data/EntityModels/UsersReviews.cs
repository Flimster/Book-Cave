using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace BookCave.Data.EntityModels
{
    public class UsersReviews
    {
        public int Id { get; set; }
         [ForeignKey("AspNetUsers")]
        public string AspNetUsersId { get; set; }
        public virtual IdentityUser AspNetUsers { get; set; }
        [ForeignKey("Reviews")]
        public int ReviewId { get; set; }
        public virtual Reviews Reviews { get; set; }
    }
}