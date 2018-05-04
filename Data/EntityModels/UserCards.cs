using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class UserCards
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
        [ForeignKey("Card")]
        public int CardId { get; set; }
        public virtual CardDetails Card { get; set; }
        
        #region NavigationProperties
        public virtual List<CardDetails> CardList { get; set; }
        //public Review Reviews { get; set; }
        #endregion
    }
}