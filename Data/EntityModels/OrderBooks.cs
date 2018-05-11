using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class OrdersBooks
    {
        public int Id { get; set; }
        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        public virtual Orders Orders { get; set; }
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public virtual Books Books { get; set; }
        public int Quantity { get; set; }
    }
}