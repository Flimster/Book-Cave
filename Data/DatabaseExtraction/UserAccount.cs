using System;

namespace BookCave.Data.DatabaseExtraction
{
    public class UserAccount
    {
        public int Id {get;set;}
        public string Image { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int FavoriteBookId  { get; set; }
        public int FavoriteAuthorId { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLogIn { get; set; }
        public int BookSuggestionEmail { get; set; }
        public int ActiveStatus { get; set; }
        public int UserGroup { get; set; } 
        public int TotalReports { get; set; }
        public int TotalBans { get; set; }
    }
}