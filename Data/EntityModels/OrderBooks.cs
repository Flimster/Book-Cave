using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class OrdersBooks
    {
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Orders Order { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Books Book { get; set; }
    }
}