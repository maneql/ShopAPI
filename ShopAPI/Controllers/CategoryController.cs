using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Models;
using ShopAPI.IRepository;
using Newtonsoft.Json;


namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly IRCategory _iCategory;

        public CategoryController(IRCategory iRCategory)
        {
            _iCategory = iRCategory;
        }

        [HttpGet]
        public Task<string> Get()
        {
            // test2
            // abc bn
            return this.GetAllCategory();
        }

        public async Task<string> GetAllCategory()
        {
            var cate = await _iCategory.Get();
            return JsonConvert.SerializeObject(cate);
        }

        [HttpGet("{id}")]
        public Task<string> Get(int id)
        {
            return this.GetCategoryID(id);
        }

        public async Task<string> GetCategoryID(int id)
        {
            var cate = await _iCategory.Get(id);
            return JsonConvert.SerializeObject(cate);
        }

        [HttpPost]
        public async Task<string> Post([FromBody] Category category)
        {
            return JsonConvert.SerializeObject(await _iCategory.Add(category));
        }

        [HttpPut]
        public async Task<string> Put([FromBody] Category category)
        {
            return JsonConvert.SerializeObject(await _iCategory.Update(category));
        }

        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return JsonConvert.SerializeObject(await _iCategory.Remove(id));
        }
    }
}
