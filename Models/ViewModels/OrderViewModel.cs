using System;
using System.Collections.Generic;
using BookCave.Models.ViewModels;
using BookCave.Data.EntityModels;

namespace BookCave.Models.ViewModels
{
	public class OrderViewModel
	{
		public int Id { get; set; }
		public string User { get; set; }
		public DateTime Date { get; set; }
		public bool Status { get; set; }
		public double Price { get; set; }
		public List<BookViewModel> BookList { get; set; }
		public int Quantity { get; set; }
	}
}