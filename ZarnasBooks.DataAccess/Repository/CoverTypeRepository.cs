using System;
using System.Collections.Generic;
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
    }
}
