using System;
using System.Collections.Generic;
using BookCave.Models.ViewModels;
using BookCave.Data.EntityModels;

namespace BookCave.Models.ViewModels
{
	public class OrderViewModel
	{
		public int Id { get; set; }
		public AspNetUsers User { get; set; }
		public DateTime OrderDate { get; set; }
		public bool OrderStatus { get; set; }
		public double OrderPrice { get; set; }
		public List<BookViewModel> BookList { get; set; }
	}
}