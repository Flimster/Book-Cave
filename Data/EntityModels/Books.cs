using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
	public class Books
	{
		public int Id { get; set; }
		public string Title { get; set; }	
		public int ReleaseYear { get; set; }
		public double Price { get; set; }
		public string Description { get; set; }
		public double Rating { get; set; }      
		public string ISBN10 { get; set; }
		public string ISBN13 { get; set; }
		public int StockCount { get; set; }
		public bool Visibility { get; set; }
		public  int Format { get; set; }
		public string Image {get;set;}
		public string Publisher { get; set; }
		public double Discount {get; set;}

	}
}