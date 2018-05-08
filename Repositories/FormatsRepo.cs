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

        public List<Formats> GetList()
        {
            var format = (from F in _db.Formats
                        select new Formats
                        {
                            Id = F.Id,
                            Name = F.Name,
                        }).ToList();
            
            return format;
        }

        public void Write(Formats formats)
        {
            _db.Add(formats);
            _db.SaveChanges();
        }

        public void Remove(Formats format)
        {
            _db.Remove(format);
            _db.SaveChanges();
        }
    }
}