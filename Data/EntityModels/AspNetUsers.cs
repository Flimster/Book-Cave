using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace BookCave.Data.EntityModels
{
    public class AspNetUsers : IdentityUser
    {
        public string Image { get; set; }
        public string Name { get; set; }
        [ForeignKey("FavoriteBook")]
        public int FavoriteBookId { get; set; }
        public virtual Book FavoriteBook { get; set; }
        [ForeignKey("FavoriteAuthor")]
        public int FavoriteAuthorId { get; set; }
        public virtual Author FavoriteAuthor { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLoggedInDate { get; set; }
        public bool BookSuggestionsEmail { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserGroup { get; set; }
        public int TotalReports { get; set; }
        public int TotalBans { get; set; }
    }
}