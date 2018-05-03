using System;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class UserAccount
    {
        public int Id {get;set;}
        public string Image { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //0 - Default/None
        public int FavoriteBookId  { get; set; }
        //0 - Default/None
        public int FavoriteAuthorId { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLogIn { get; set; }
        public int BookSuggestionEmail { get; set; }
        //0 - Inactive, 1 - Active
        public int ActiveStatus { get; set; }
        //0 - Visitor, 1 - Customer, 2 - Admin
        public int UserGroup { get; set; } 
        public int TotalReports { get; set; }
        public int TotalBans { get; set; }
    }
}