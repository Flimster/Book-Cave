using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Data.EntityModels;
using BookCave.Models;
using Microsoft.AspNetCore.Identity;

namespace BookCave.Data.EntityModels
{
    public class UserOrders
    {
        public int Id { get; set; }
        [ForeignKey("AspNetUsers")]
        public string AspNetUsersId { get; set; }
        public virtual IdentityUser AspNetUsers { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Orders Order { get; set; }
    }
}