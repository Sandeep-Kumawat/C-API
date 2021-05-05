using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }

    public class Operation
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public string Operands { get; set; }
    }
}
