using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace BookCave.Data.EntityModels
{
    public class AspNetUsers : IdentityUser
    {
        public string CustomId {get; set;}
        public string Image { get; set; }
        public string Name { get; set; }
        [ForeignKey("Book")]
        public int FavoriteBookId { get; set; }
        public virtual Books Books { get; set; }
        [ForeignKey("Author")]
        public int FavoriteAuthorId { get; set; }
        public virtual Authors Authors { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLoggedInDate { get; set; }
        public bool BookSuggestionsEmail { get; set; }
        public int TotalReports { get; set; }
        public int TotalBans { get; set; }
    }
}