using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class UserShipping
    {
        public int Id { get; set; }
        [ForeignKey("UsrId")]
        public int UserId { get; set; }
        public UserAccount UsrId { get; set; }
        [ForeignKey("ShpId")]
        public int ShippingId { get; set; }
        public Address ShpId { get; set; }
    }
}