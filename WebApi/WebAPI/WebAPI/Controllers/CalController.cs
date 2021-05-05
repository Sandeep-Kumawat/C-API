using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalController : ControllerBase
    {
        [HttpGet("greet")]
        public string greet()
        {
            return "Hello Sandeep";
        }
        [HttpGet("products")]
        public List<Product> products()
        {
            var p = new List<Product>
            {
                new Product
                {
                    Name="Pen",
                    Price=20,
                    Quantity=5
                },
                 new Product
                {
                    Name="Pencil",
                    Price=10,
                    Quantity=3
                }
            };
            return p;
        }
        [HttpPost("Calculate")]
        public int cal(Operation op)
        {
            int res = 0;
            if(op.Operands == "+")
            {
                res = op.num1 + op.num2;
            }
            else if (op.Operands == "-")
            {
                res = op.num1 - op.num2;
            }
            else if (op.Operands == "*")
            {
                res = op.num1 * op.num2;
            }
            if (op.Operands == "+")
            {
                res = op.num1 + op.num2;
            }
            else if (op.Operands == "-")
            {
                res = op.num1 - op.num2;
            }
            else if (op.Operands == "*")
            {
                res = op.num1 * op.num2;
            }
            else if (op.Operands == "/") 
            {
                res = op.num1 / op.num2;
            }
            else
            {
                return -1;
            }
            return res;
        }
    }
}
