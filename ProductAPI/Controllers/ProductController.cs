using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Data;

namespace ProductAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase{
        private readonly ApplicationDbContext _context;
        public List<Product> ProductList;
        public ProductController(ApplicationDbContext context){
            if(ProductList == null){
                ProductList = new List<Product>();
            }
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll(){
            return _context.Product.ToList();
        }

        // [HttpPost]
        // public IEnumerable<Product> AddProduct(){
        //     _context.Products.Add(new Product(){
        //         Name = "Güzel Seramik Tabak",
        //         Description = "Şık tasarım, günlük kullanım için ideal"
        //     });
        //     return _context.Products.ToArray();
        // }
    }
}