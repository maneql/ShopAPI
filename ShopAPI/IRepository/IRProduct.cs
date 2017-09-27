using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopAPI.Models;

namespace ShopAPI.IRepository
{
    public interface IRProduct
    {
        Task<IEnumerable<Product>> Get();

        Task<Product> Get(int id);

        Task<Product> Add(Product product);

        Task<Product> Update(Product product);

        Task<bool> Remove(int id);

    }
}
