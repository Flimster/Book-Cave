using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Models;
using BookCave.Data.EntityModels;

namespace BookCave.Data.EntityModels
{
    public class Feedback
    {
        public int Id { get; set; }
        [ForeignKey("AspNetUsers")]
        public string AspNetUsersId { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}