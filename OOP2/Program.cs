// See https://aka.ms/new-console-template for more information
using OOP2;

//Customer customer1 =  new Customer();
//customer1.FirstName = "Engin";
//customer1.LastName = "Demiroğ";
//customer1.Id= 1;
//customer1.TcNo ="22222222222";
//customer1.VergiNo = "12345";
//customer1.CompanyName = "?";
//Gerçek Müşteri - Tüzel Müşteri
GercekMusteri customer1 = new GercekMusteri();
customer1.Id=1;
customer1.CustomerNumber = "12345";
customer1.FirstName = "Engin";
customer1.LastName = "Demiroğ";
TuzelMusteri customer2 = new TuzelMusteri();
customer2.Id=2;
customer2.CustomerNumber = "54321";
customer2.CompanyName = "Kodlama.io";
customer2.VergiNo = "1234567890";
//Gerçek Müşteri - Tüzel Müşteri
//SOLID
Customer customer3 = new GercekMusteri();
Customer customer4 = new TuzelMusteri();
