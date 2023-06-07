using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeWorkAbstr
{
    public class Reception
    {
        public string Descriptions { get; }

        public string Products { get; set; }

        public int ProductQuanty { get; set; }

        public double ProductPrice { get; set; }

        public Reception() { }
        public Reception(string descriptions, string products, int productquanty, double productprice)
        {
            Descriptions = "Reception";
            Products = products;
            ProductQuanty = productquanty;
            ProductPrice = productprice;
        }

        public string Description ()
        {
            return $"{Description},name of products {Products} , product price : {ProductPrice}, " +
                $"quanty :{ProductQuanty}. And {(ProductQuanty * ProductPrice)}";
        }
    }
}
