using System.Collections.Generic;

namespace BookCave.Models.ViewModels
{
    public class SearchViewModel
    {
        public List<BookViewModel> BookList { get; set; }
        public string Title { get; set; }
        public int Genre { get; set; }
        public int Author  { get; set; }
        public int Price { get; set; }
        public int Language { get; set; }
        public int Format { get; set; }
    }
}