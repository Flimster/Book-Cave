using System.Collections.Generic;
using BookCave.Data.EntityModels;

namespace Book_Cave.Models.RegistrationModels
{
    public class BookRegistrationModel
    {
        public string Title { get; set; }
        public List<int> AuthorId { get; set; }
        public List<string> Genre { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public string ISBN10 { get; set; }
        public string ISBN13 { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public bool Visibility { get; set; }
        public string Publisher { get; set; }
        public List<Formats> Formats { get; set; }
    }
}