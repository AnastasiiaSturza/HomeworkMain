using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeWorkAbstr
{
    public class Buyer
    {
        public string FullName { get; set; }
        public string Adress { get; set; }
        public Reception[] Receptions { get; set; } = new Reception[0];

        public Product[] Products { get; set; } = new Product[0];

       

        public Buyer() { }
        public Buyer(string fullName, string adress, Reception[] receptions, Product[] products)
        {
            FullName = fullName;
            Adress = adress;
            Receptions = receptions;
            Products = products;
        }

        public void AddReception(Reception reception)   // method for add new products to Products
        {
            Reception[] addReception = new Reception[Receptions.Length + 1];

            for (int i = 0; i < Products.Length; i++)
            {

                addReception[i] = Receptions[i];
            }
            addReception[Receptions.Length] = reception;

            Receptions = addReception;
        }



    }

    public class Stuff : Buyer
    {
        public Stuff() { }
        public Stuff(string fullName)
        {
            FullName = fullName;
        }
    }
}
