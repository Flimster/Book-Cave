using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Data.EntityModels;
using BookCave.Models;
using Microsoft.AspNetCore.Identity;

namespace BookCave.Data.EntityModels
{
    public class UsersOrders
    {
        public int Id { get; set; }
        [ForeignKey("AspNetUsers")]
        public string AspNetUserId { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Orders Order { get; set; }
    }
}