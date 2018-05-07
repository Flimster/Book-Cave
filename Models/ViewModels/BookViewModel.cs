using System.Collections.Generic;

namespace BookCave.Models.ViewModels

{
    public class BookViewModel
    {
      public int Id { get; set; }
      public string Title { get; set; }
      public List<string> Author { get; set; }
      public string Genre { get; set; }
      public string Image { get; set; }
      public double Price { get; set; }
    }
}