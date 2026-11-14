using  Models.Course;
using Models.TravelCard;

var course = new Course();
Console.WriteLine(course.GetInfo());

var course2 = new Course("OOP");
Console.WriteLine(course2.GetInfo());
var course3 = new Course("LINQ", 8);
Console.WriteLine(course3.GetInfo());
Console.WriteLine("\n---------------------\n");


var trCard01 = new TravelCard("TC01", 100);
var trCard02 = new TravelCard("TC02", 0);

bool result = trCard01.Pay(30);
Console.WriteLine($"{result}, TC01={trCard01.Balance}, TC02={trCard02.Balance}");

result = trCard01.Pay(80);
Console.WriteLine($"{result}, TC01={trCard01.Balance}, TC02={trCard02.Balance}");

result = trCard01.TopUp(50);
Console.WriteLine($"{result}, TC01={trCard01.Balance}, TC02={trCard02.Balance}");

result = trCard01.Pay(80);
Console.WriteLine($"{result},TC01={trCard01.Balance}, TC02={trCard02.Balance}");

result = trCard02.TopUp(-10);
Console.WriteLine($"{result}, TC01={trCard01.Balance}, TC02={trCard02.Balance}");

result = trCard02.Pay(1);
Console.WriteLine($"{result}, TC01={trCard01.Balance}, TC02={trCard02.Balance}");

