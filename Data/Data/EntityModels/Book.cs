using System.Collections.Generic;

namespace BookCave.Data.EntityModels
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string CoverPhoto { get; set; }
		public int PageCount { get; set; }
		public int PublisherId { get; set; }
		public int ReleaseYear { get; set; }
		public double Price { get; set; }
		public string Description { get; set; }
		public double Rating { get; set; }       //////////// Rating Rating
		public int ISBN10 { get; set; }
		public int ISBN13 { get; set; }
		public int StockCount { get; set; }
		public bool Visibility { get; set; }
		public Format BookFormatId { get; set; }
		public Format BookFormat { get; set; }

		#region NavigationProperties
		public List<Author> AuthorId { get; set; }
		public Author Author {get; set;}
		public List<Genre> GenreId { get; set; }
		public Genre Genre { get; set; }
		public List<Language> LanguageId { get; set; }
		public Language Language {get; set;}
		#endregion
	}
}