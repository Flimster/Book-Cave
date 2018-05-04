using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Models.ViewModels;

namespace BookCave.Data.EntityModels
{
    public class UserReviewList
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        [ForeignKey("Review")]
        public int ReviewId { get; set; }
        public virtual Review Review { get; set; }

        #region NavigationProperties
        public virtual List<Review> ReviewList { get; set; }
        //public Review Reviews { get; set; }
        #endregion

    }
}