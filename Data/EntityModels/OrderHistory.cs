using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Data.EntityModels;
using BookCave.Models;


namespace BookCave.Data.EntityModels
{
    public class OrderHistory
    {
        public int Id { get; set; }
        [ForeignKey("AspNetUsers")]
        public string  AspNetUsersId { get; set; }
        public virtual AspNetUsers AspNetUsers {get;set;}
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}