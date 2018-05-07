using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		[ForeignKey("BookAuthors")]
		public int BookAuthorsId { get; set; }
		public virtual BookAuthors BookAuthors { get; set; }
		[ForeignKey("BookLanguages")]
		public int BookLanguageId { get; set; }
		public virtual BookLanguages BookLanguages { get; set; }
		[ForeignKey("BookGenre")]
		public int BookGenreId { get; set; }
		public virtual BookGenre BookGenre { get; set; }
		public string CoverPhoto { get; set; }
		public int PageCount { get; set; }
		[ForeignKey("Publisher")]
		public int PublisherId { get; set; }
		public virtual Publisher Publisher {get; set;}
		public int ReleaseYear { get; set; }
		public double Price { get; set; }
		public string Description { get; set; }
		public double Rating { get; set; }       //////////// Rating Rating
		public int ISBN10 { get; set; }
		public int ISBN13 { get; set; }
		public int StockCount { get; set; }
		public bool Visibility { get; set; }
		[ForeignKey("BookFormat")]
		public int BookFormatId { get; set; }
		public virtual Formats BookFormat { get; set; }
	}
}