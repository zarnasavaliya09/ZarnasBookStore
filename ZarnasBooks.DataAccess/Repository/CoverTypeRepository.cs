using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZarnasBooks.DataAccess.Repository.IRepository;
using ZarnasBooks.Models;
using ZarnasBookStore.DataAccess.Data;

namespace ZarnasBooks.DataAccess.Repository
{
    public class CoverTypeRepository: Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(CoverType coverType)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
                _db.SaveChanges();
            }
        }
    }
}
