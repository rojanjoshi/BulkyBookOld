using BulkyBookOld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBookOld.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public interface ICategoryRepository : IRepository<Category>
        {
            void Update(Category category);
        }
    }
}
