using System.Linq;
using BookCave.Models.ViewModels;

namespace BookCave.Services
{
    public class SearchService
    {
        public SearchViewModel FilterByTitle(SearchViewModel searchResults)
        {
            searchResults.BookList = (from Bo in searchResults.BookList
                                      where (Bo.Title.ToLower()).Contains(searchResults.Title.ToLower())
                                      select Bo).ToList();
            return searchResults;
        }

        public SearchViewModel FilterByGenre(SearchViewModel searchResults)
        {
            /*searchResults.BookList = (from Bo in searchResults.BookList
                                      where Bo == (from Ge in Bo.Genre
                                                    where Ge.Id == searchResults.Genre
                                                    select Ge)
                                      select Bo).ToList(); */

            
            //questions.Where(q => q.Answers.Any(a => a.Name == "SomeName"))

            searchResults.BookList = searchResults.BookList.Where(Bo => Bo.Genre.Any(Ge => Ge.Id == searchResults.Genre)).ToList();

            return searchResults;
        }

        public SearchViewModel FilterByAuthor(SearchViewModel searchResults)
        {
            searchResults.BookList = searchResults.BookList.Where(Bo => Bo.Authors.Any(Au => Au.Id == searchResults.Author)).ToList();
            return searchResults;
        }

        public SearchViewModel FilterByPrice(SearchViewModel searchResults)
        {
            if(searchResults.Price <= 30)
            {
              searchResults.BookList = (from Bo in searchResults.BookList
                                        where Bo.Price < searchResults.Price
                                        select Bo).ToList();
            }
            else
            {
              searchResults.BookList = (from Bo in searchResults.BookList
                                        where Bo.Price > 30
                                        select Bo).ToList();
            }
            return searchResults;
        }

        public SearchViewModel FilterByLanguage(SearchViewModel searchResults)
        {
            searchResults.BookList = searchResults.BookList.Where(Bo => Bo.Languages.Any(La => La.Id == searchResults.Language)).ToList();
            return searchResults;
        }

        public SearchViewModel FilterByFormat(SearchViewModel searchResults)
        {
            searchResults.BookList = (from Bo in searchResults.BookList
                                      where Bo.FormatsId == searchResults.Format
                                      select Bo).ToList();
            return searchResults;
        }
    }
}