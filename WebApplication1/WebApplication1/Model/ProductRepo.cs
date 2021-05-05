using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class ProductRepo
    {

        public List<Product> products = new List<Product>
        {

                  new Product
                {
                    Id = 1,
                    Title = "Pen",
                    Price = 100
                },

                 new Product
                {
                    Id = 2,
                    Title = "Pencil",
                    Price = 50 
                }


        };
        public List<Product> GetProducts()
        {
            return products;
        }
        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public Product findProduct(int i)
        {
            var res = new Product();
            products.ForEach(
                (x) =>
                {
                    if(x.Id==i)
                    {
                        res = x;
                    }
                }
                );
            return res;
        }
    }
}
