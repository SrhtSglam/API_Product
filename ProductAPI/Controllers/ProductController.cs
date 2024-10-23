using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase{
        List<Product> ProductList;

        [HttpGet]
        public IEnumerable<Product> GetAll(){
            query();
            return ProductList;
        }

        [HttpPost]
        public IEnumerable<Product> AddProduct(){
            query();
            ProductList.Add(new Product(){
                Id = 0,
                CategoryId = 1,
                Name = "Akıllı Saat",
                Description = "Bu bir saat"
            });
            return ProductList;
        }

        private void query(){
            if(ProductList == null){
                ProductList = new List<Product>();
            }
        }
    }
}