using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeWorkAbstr
{
    public class AllProduct : Product
    {
        public string Name { get; set; }
        public int Quanty { get; set; }
        public double Price { get; set; }

        
        public Product[] Products { get; set; } = new Product[0];

       
        public AllProduct() { }
        public AllProduct(string name, int quanty, double price)
        {
            Name = name;
            Quanty = quanty;
            Price = price;
        }
        public void AddAllProduct(Product product)   // method for add new products to Products
        {
            Product[] addProducts = new Product[Products.Length + 1];

            for (int i = 0; i < Products.Length; i++)
            {

                addProducts[i] = Products[i];
            }
            addProducts[Products.Length] = product;

            Products = addProducts;
        }

        

        public void RemoveAllProduct()
        {
            Product[] removeAllProduct = new Product[Products.Length - 1];
            for (int i = 0;i < Products.Length-1;i--) 
            {
                removeAllProduct[i] = Products[i];
            }
            Products = removeAllProduct;
        }
    }
}
