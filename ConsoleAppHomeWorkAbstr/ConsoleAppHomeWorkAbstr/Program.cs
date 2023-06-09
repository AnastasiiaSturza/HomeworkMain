using ConsoleAppHomeWorkAbstr;

var products1 = new AllProduct();  // add products to Shop
var product = new Product();
product.Name = "FFFF";
product.Quantity = 2;
product.Price = 2.6;
var product1 = new Product();
product1.Name = "kkkk";
product1.Quantity = 24;
product1.Price = 2.3;
products1.AddProduct(product);
products1.AddProduct(product1);
foreach (var item in products1.Products)
{
    Console.WriteLine($"Product: {item.Name}, quanty: {item.Quantity}, price : {item.Price} $ ");
}
var info = products1.FullInfo();
Console.WriteLine(info);



var reception =  new Reception();
reception.Descriptions = "Recept #1";
reception.Products = product.Name;
reception.ProductQuantity= product.Quantity;
reception.ProductPrice = product.Price;
Console.WriteLine(reception.DescriptionRecept());


products1.RemoveProduct();
