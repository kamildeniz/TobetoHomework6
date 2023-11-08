// See https://aka.ms/new-console-template for more information
using GenericsIntro;

Console.WriteLine("Hello, World!");
MyList<string> isimler = new MyList<string>();
isimler.Add("Engin");
Console.WriteLine(isimler.Length);
isimler.Add("Kerem");
Console.WriteLine(isimler.Length);
foreach (var item in isimler.Items)
{
    Console.WriteLine(item);
}