using  Models.Course;

var course = new Course();
Console.WriteLine(course.GetInfo());

var course2 = new Course("OOP");
Console.WriteLine(course2.GetInfo());
var course3 = new Course("LINQ", 8);
Console.WriteLine(course3.GetInfo());
//var course4 = new Course(" ");
//var course5 = new Course("OOP", 0);
