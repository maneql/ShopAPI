using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Models;
using ShopAPI.IRepository;
using ShopAPI.Data;

namespace ShopAPI.Repository
{
    public class RProduct : IRProduct
    {
        private readonly ObjectContext _context = null;

        public RProduct(ObjectContext context )
        {
            _context = context;
        }

        public async Task<Product> Add(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> Get(int id)
        {
            return await _context.Products.SingleOrDefaultAsync(p => p.Product_Id == id);
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                var prod = await _context.Products.SingleOrDefaultAsync(p => p.Product_Id == id);
                _context.Products.Remove(prod);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<Product> Update(Product product)
        {
            try
            {
                _context.Update(product);
                await _context.SaveChangesAsync();
                return product;
            }
            catch
            {
                var prod = await _context.Products.FindAsync(product.Product_Id);
                return prod;
            }
        }
    }
}
