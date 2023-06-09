using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeWorkAbstr
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        


        public Product() {}
        public Product(string name,  int quanty, double price)
        {
            Name = name;
            Quantity = quanty;
            Price = price;
        }

       

    }
}
