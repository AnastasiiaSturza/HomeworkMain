using ConsoleAppHomeWorkAbstr;

var products1 = new AllProduct();  // add products to Shop
var product = new Product();
product.Name = "FFFF";
product.Quanty= 2;
product.Price = 2.6;
products1.AddAllProduct(product);
Console.WriteLine();
products1.RemoveAllProduct();

var reception =  new Reception();
reception.Products = product.Name;
reception.ProductQuanty= product.Quanty;
reception.ProductPrice = product.Price;
Console.WriteLine(reception.Description());
