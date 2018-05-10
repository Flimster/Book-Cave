using BookCave.Models.ViewModels;
using BookCave.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookCave.Controllers
{
    public class SearchController : Controller
    {
        private readonly BookService _bookService;
        private readonly SearchService _searchService;
        
        public SearchController()
        {
          _bookService = new BookService();
          _searchService = new SearchService();
        }

        public IActionResult Index(string title, int genre = 0, int author = 0, int price = 0, int language = 0, int format = 0)
        {
          SearchViewModel searchResults = new SearchViewModel();
          searchResults.BookList = _bookService.GetList();
          
          if(title != null)
          {
            searchResults.Title = title;
            searchResults = _searchService.FilterByTitle(searchResults);
          }

          if(genre != null && genre != 0)
          {
            searchResults.Genre = genre;
            searchResults = _searchService.FilterByGenre(searchResults);
          }

          if(author != null && author != 0)
          {
            searchResults.Author = author;
            searchResults = _searchService.FilterByAuthor(searchResults);
          }

          if(price != null && price != 0)
          {
            searchResults.Price = price; 
            searchResults = _searchService.FilterByPrice(searchResults);
          }

          if(language != null && language != 0)
          {
            searchResults.Language = language;
            searchResults = _searchService.FilterByLanguage(searchResults);
          }

          if(format != null && format != 0)
          {
            searchResults.Format = format;
            searchResults = _searchService.FilterByFormat(searchResults);
          }

          return View(searchResults);
        }
    }
}