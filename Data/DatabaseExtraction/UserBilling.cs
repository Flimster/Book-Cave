using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Cave.Data.DatabaseExtraction
{
    public class UserBilling
    {
        public int Id { get; set; }
        [ForeignKey("UsrId")]
        public int UserId { get; set; }
        public UserAccount UsrId { get; set;}
        [ForeignKey("AdrId")]
        public int AddressId { get; set; }
        public Address AdrId { get; set; }
    }
}