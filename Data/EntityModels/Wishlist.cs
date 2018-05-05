using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Models;
using BookCave.Data.EntityModels;


namespace BookCave.Data.EntityModels
{
    public class Wishlist
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; } 
        public Book Book { get; set; }

        #region NavigationProperties
        public virtual List<Book> WishList { get; set; }
        //public virtual Book WishList { get; set; }
        #endregion
    }
}