using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase{
        [HttpGet]
        public IEnumerable<Product> GetAll(){
            return Enumerable.Range(1, 3).Select(index => new Product
            {
                Id = 0,

            }).ToArray();
        }

        // [HttpPost]
        // public List<Product> AddProduct(){
        //     return Enumerable<Product>new Product{
        //         Id = 0,
        //         CategoryId = 1,
        //         Name = "Serhat",
        //         Description = "depwalfpğwelaflpğeflpğa"
                
        //     }).ToArray();
        // }
    }
}