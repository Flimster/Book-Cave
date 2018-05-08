using System;
using System.Collections.Generic;
using BookCave.Data.EntityModels;

namespace BookCave.Models.ViewModels
{
    public class AspNetUserViewModel
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public List<BookViewModel> FavoriteBook { get; set; }
        public List<AuthorViewModel> FavoriteAuthor { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLoginDate {get; set;}
        public bool BookSuggestionsEmail { get; set; }
        public bool ActiveStatus { get; set; }
        public int TotalReports { get; set; }
        public int TotalBans { get; set; }
    }
}