using System;
using System.Collections.Generic;
using BookCave.Models.ViewModels;

namespace BookCave.Models.ViewModels
{
	public class OrderViewModel
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public DateTime OrderPlaced { get; set; }
		public bool OrderStatus { get; set; }
		public double TotalPrice { get; set; }
		public List<BookViewModel> BookList { get; set; }
	}
}