using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopAPI.Models;
using ShopAPI.IRepository;
using ShopAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ShopAPI.Repository
{
    public class RCategory : IRCategory
    {
        private readonly ObjectContext _context = null;

        public RCategory(ObjectContext context)
        {
            _context = context;
        }

        public async Task<Category> Add(Category chucvu)
        {
            await _context.Categorys.AddAsync(chucvu);
            await _context.SaveChangesAsync();
            return chucvu;
        }

        public async Task<IEnumerable<Category>> Get()
        {
            return await _context.Categorys.ToListAsync();
        }

        public async Task<Category> Get(int id)
        {
            return await _context.Categorys.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                var cate = await _context.Categorys.SingleOrDefaultAsync(c => c.Id == id);
                _context.Categorys.Remove(cate);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public Task<bool> RemoveAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Category> Update(Category category)
        {
            try
            {
                _context.Update(category);
                await _context.SaveChangesAsync();
                return category;
            }
            catch
            {
                var cate = await _context.Categorys.FindAsync(category.Id);
                return cate;
            }
        }
    }
}
