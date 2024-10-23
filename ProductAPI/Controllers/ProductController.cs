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

        [HttpPost]
        public IEnumerable<Product> AddProduct([FromQuery]int id, [FromQuery]int categoryid, [FromQuery]string name, [FromQuery]string description){
            ProductList.Clear();
            ProductList.Add(new Product(){
                Id = id,
                CategoryId = categoryid,
                Name = name,
                Description = description
            });
            _context.Product.AddRange(ProductList);
            _context.SaveChanges();
            return _context.Product.ToList();
        }
    }
}