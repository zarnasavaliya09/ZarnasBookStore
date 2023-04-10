﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZarnasBooks.DataAccess.Repository.IRepository;
using ZarnasBooks.Models;
using ZarnasBookStore.DataAccess.Data;

namespace ZarnasBooks.DataAccess.Repository
{
    public class CategoryRepository:Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }  
        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault();
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
