using System;
using System.Collections.Generic;

namespace BookCave.Models.ViewModels
{
    public class FeedbackViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public List<OrderViewModel> Order { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}