using System.Collections.Generic;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;

namespace BookCave.Models.ViewModels

{
    public class BookViewModel
    {
      public int Id { get; set; }
      public string Title { get; set; }
      public List<AuthorViewModel> Authors { get; set; }
      public List<GenreViewModel> Genre { get; set; }
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
      public Formats Format { get; set; }
      public double Discount { get; set; }
      public List<ReviewViewModel> Reviews {get; set;}
      public int Quantity { get; set; }
    }
}