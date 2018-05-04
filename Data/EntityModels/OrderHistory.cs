using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;

namespace BookCave.Data.EntityModels
{
    public class OrderHistory
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public string  UserId { get; set; }
        public virtual ApplicationUser User {get;set;}
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public virtual List<Order> OrderList { get; set; }
        //public virtual Order OrderHistory { get; set; }
    }
}