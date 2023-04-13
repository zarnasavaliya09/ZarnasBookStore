using System;
using System.Collections.Generic;
using System.Text;
using ZarnasBooks.Models;

namespace ZarnasBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        void Update(Category category);
    }
}
