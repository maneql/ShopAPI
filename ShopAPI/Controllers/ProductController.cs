using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopAPI.IRepository;
using ShopAPI.Models;

namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IRProduct _iRProduct;

        public ProductController(IRProduct iRProduct)
        {
            _iRProduct = iRProduct;
        }

        [HttpGet]
        public Task<string> Get()
        {
            return this.GetAllProduct();
        }

        public async Task<string> GetAllProduct()
        {
            return JsonConvert.SerializeObject(await _iRProduct.Get());
        }

        [HttpGet("{id}")]
        public Task<string> Get(int id)
        {
            return this.GetProductById(id);
        }

        public async Task<string> GetProductById(int id)
        {
            return JsonConvert.SerializeObject(await _iRProduct.Get(id));
        }

        [HttpPost]
        public async Task<string> Post([FromBody]Product product)
        {
            return JsonConvert.SerializeObject(await _iRProduct.Add(product));
        }

        [HttpPut]
        public async Task<string> Put([FromBody]Product product)
        {
            return JsonConvert.SerializeObject(await _iRProduct.Update(product));
        }

        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return JsonConvert.SerializeObject(await _iRProduct.Remove(id));
        }
    }
}
