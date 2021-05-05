using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiDemo : ControllerBase
    {
        [HttpGet("getProduct")]
        public List<Product> GetProducts()
        {
            ProductRepo p = new ProductRepo();
            var a = p.GetProducts();
            return a;
        }

        [HttpPost("addProduct")]
       public List<Product> AddProduct(Product p)
        {
            ProductRepo p1 = new ProductRepo();
            p1.AddProduct(p);
            return p1.GetProducts();

            
        }
        [HttpGet("findProduct")]

        public Product FindProduct(int i)
        {
            ProductRepo p = new ProductRepo();
            return p.findProduct(i);
        }
    }
}
