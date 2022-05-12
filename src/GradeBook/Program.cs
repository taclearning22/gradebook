// See https://aka.ms/new-console-template for more information
var x = 25.23; 
var y = 12.54;

var grades = new List<double>(){12.11, 256, 546.21};
grades.Add(56.1);

var result = 0.0;
var average = 0.0;

foreach(double number in grades)
{
    result += number;
}
average = result/grades.Count;

Console.WriteLine($"The total is {result}");
Console.WriteLine($"The average is {average}");

Console.WriteLine($"The result of x + y = {x+y}!");

if (args.Length > 0)
    Console.WriteLine($"Hello, {args[0]}!");
else 
    Console.WriteLine("Hello C#!");
