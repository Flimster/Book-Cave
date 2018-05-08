using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using System.Linq;

namespace BookCave.Repositories
{
    public class FormatsRepo
    {
        private DataContext _db;

        public FormatsRepo()
        {
            _db = new DataContext();
        }

        public List<Formats> GetFormatList()
        {
            var format = (from F in _db.Formats
                        select new Formats
                        {
                            Id = F.Id,
                            Name = F.Name,
                        }).ToList();
            
            return format;
        }

        public void WriteFormat(Formats formats)
        {
            _db.Add(formats);
            _db.SaveChanges();
        }
    }
}