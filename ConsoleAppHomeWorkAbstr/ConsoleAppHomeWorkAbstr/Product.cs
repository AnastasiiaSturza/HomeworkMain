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
        public int Quanty { get; set; }
        public double Price { get; set; }

        


        public Product() {}
        public Product(string name,  int qyanty, double price)
        {
            Name = name;
            Quanty = qyanty;
            Price = price;
        }

       

    }
}
