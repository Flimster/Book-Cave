using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Models;
using BookCave.Data.EntityModels;
using Microsoft.AspNetCore.Identity;

namespace BookCave.Data.EntityModels
{
    public class Feedback
    {
        public int Id { get; set; }
         [ForeignKey("AspNetUsers")]
        public string AspNetUsersId { get; set; }
        public virtual IdentityUser AspNetUsers { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}