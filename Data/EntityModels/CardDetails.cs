using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class CardDetails
    {
        public int Id { get; set; }
        [ForeignKey("AspNetUsers")]
        public string AspNetUserId { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public int Cvc { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}