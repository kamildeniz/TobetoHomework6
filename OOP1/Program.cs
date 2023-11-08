// See https://aka.ms/new-console-template for more information
using OOP1;

Product product1 = new Product();
product1.Id= 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice=15.50;
product1.UnitsInStock=5;
Product product2 = new Product
{
    Id = 2,
    CategoryId = 5,
    UnitsInStock = 5,
    ProductName = "Kalem",
    UnitPrice=500.20

};
ProductManager productManager = new ProductManager();
productManager.Add(product1);
productManager.Topla2(3, 6);
int toplamSonucu = productManager.Topla(3, 6);
Console.WriteLine(toplamSonucu*2);