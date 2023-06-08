using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeWorkAbstr
{
    public class Reception : IShop
    {
        public string Descriptions { get; set; }

        public string Products { get; set; }

        public int ProductQuantity { get; set; }

        public double ProductPrice { get; set; }

        public Reception() { }
        public Reception(string description, string products, int productquanty, double productprice)
        {
            Descriptions = description;
           
            Products = products;
            ProductQuantity = productquanty;
            ProductPrice = productprice;
        }

        public string DescriptionRecept ()
        {
            return $"{Descriptions},name of products {Products} , product price : {ProductPrice} $, " +
                $"quanty :{ProductQuantity}. And total price: {(ProductQuantity * ProductPrice)} $";
        }
    }
}
