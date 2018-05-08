using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Models;
using BookCave.Data.EntityModels;
using Microsoft.AspNetCore.Identity;

namespace BookCave.Data.EntityModels
{
    public class Reviews
    {
        public int Id { get; set; }
        public string AspNetUsersId { get; set; }
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public virtual Books Books { get; set; }
        public string Text { get; set; }
        public double Rating { get; set; }
        public DateTime Date { get; set; }
        public int PositiveScore { get; set; }
        public int NegativeScore { get; set; }
        public bool Edited {get; set;}
    }
}