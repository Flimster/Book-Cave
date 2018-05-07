using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Models;
using BookCave.Data.EntityModels;
using Microsoft.AspNetCore.Identity;

namespace BookCave.Data.EntityModels
{
    public class Review
    {
        public int Id { get; set; }
        [ForeignKey("AspNetUsers")]
        public string AspNetUsersId { get; set; }
        public virtual IdentityUser AspNetUsers { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public string Text { get; set; }
        public double Rating { get; set; }
        public DateTime Date { get; set; }
        public int PositiveScore { get; set; }
        public int NegativeScore { get; set; }
        public bool Edited {get; set;}
    }
}