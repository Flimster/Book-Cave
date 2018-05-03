using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCave.Data.EntityModels
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}