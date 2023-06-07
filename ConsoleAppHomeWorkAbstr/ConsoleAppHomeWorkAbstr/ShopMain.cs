using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeWorkAbstr
{
    public class ShopMain
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public AllProduct[] AllProducts { get; set; } = new AllProduct[0];
        public Buyer[] Buyers { get; set; }= new Buyer[0];
        public Reception[] Receptions { get; set; } = new Reception[0];

        public ShopMain (string name, string description, AllProduct[] products, Buyer[] buyers, Reception[] receptions)
        {
            Name = name;
            Description = description;
            AllProducts = products;
            Buyers = buyers;
            Receptions = receptions;
        }
        public ShopMain() { }
        


    }
}
