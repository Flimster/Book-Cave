using System.Collections.Generic;
using Book_Cave.Models.ViewModels;
using BookCave.Models.ViewModels;

namespace BookCave.Models.ViewModels

{
    public class BookViewModel
    {
      public int Id { get; set; }
      public string Title { get; set; }
      public List<AuthorViewModel> Authors { get; set; }
      public string Genre { get; set; }
      public string Image { get; set; }
      public double Price { get; set; }
      public string ISBN10 { get; set; }
      public string ISBN13 { get; set; }
    }
}