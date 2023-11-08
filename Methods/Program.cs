// See https://aka.ms/new-console-template for more information
using Methods;

Console.WriteLine("Hello, World!");
Product product1 = new Product();
product1.Name = "Elma";
product1.Description = "Amasya Elması buuuu!";
product1.Price = 100;
Product product2 = new Product();
product2.Name = "Gül";
product2.Description = "Isparta Gülü Looooo!";
product2.Price = 100;
List<Product> products = new List<Product>();
products.Add(product1);
products.Add(product2);
foreach (var product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Description);
    Console.WriteLine(product.Price);
    Console.WriteLine("--------------------");
}
Console.WriteLine("------Methods----------");
BasketManager basketManager = new BasketManager();
basketManager.Add(product1);
basketManager.Add(product2);
basketManager.Add(product1);
basketManager.Add(product2);
basketManager.Add(product1);