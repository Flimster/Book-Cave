using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Models;
using BookCave.Data.EntityModels;
using Microsoft.AspNetCore.Identity;

namespace BookCave.Data.EntityModels
{
    public class Feedbacks
    {
        public int Id { get; set; }
         [ForeignKey("AspNetUsers")]
        public string AspNetUserId { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}