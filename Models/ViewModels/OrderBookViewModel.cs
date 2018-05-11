using System.Collections.Generic;

namespace BookCave.Models.ViewModels
{
    public class OrderBookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<AuthorViewModel> Authors { get; set; }
        public List<GenreViewModel> Genre { get; set; }
        public List<LanguageViewModel> Language {get; set;}
        public string Image { get; set; }
        public double Price { get; set; }
        public string ISBN10 { get; set; }
        public string ISBN13 { get; set; }
        public string Description { get; set; }
        public List<LanguagesViewModel> Languages { get; set; }
        public string Publisher { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }
        public int StockCount { get; set; }
        public int FormatId { get; set; }
        public double Discount { get; set; }
        public int NumOfBooks { get; set; }
    }
}