using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopAPI.Models;

namespace ShopAPI.IRepository
{
    public interface IRCategory
    {
        Task<IEnumerable<Category>> Get();

        Task<Category> Get(int id);

        Task<Category> Add(Category chucvu);

        Task<Category> Update(Category chucvu);

        Task<bool> Remove(int id);

        Task<bool> RemoveAll();
    }
}
