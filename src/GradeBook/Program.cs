// See https://aka.ms/new-console-template for more information

#region Using the New Program Style
// var x = 25.23;
// var y = 12.54;

// var grades = new List<double>() { 12.11, 256, 546.21 };
// grades.Add(56.1);

// var stats = 0.0;
// var average = 0.0;

// foreach (double number in grades)
// {
//     stats += number;
// }
// average = stats / grades.Count;

// Console.WriteLine($"The total is {stats}");
// Console.WriteLine($"The average is {average}");

// Console.WriteLine($"The stats of x + y = {x + y}!");

// if (args.Length > 0)
//     Console.WriteLine($"Hello, {args[0]}!");
// else
//     Console.WriteLine("Hello C#!");

#endregion


#region Using the Old Program Style
namespace GradeBook // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var book = new DiskBook("John's GradeBook");
            book.GradeAdded += OnGradeAdded;

            var grades = new List<double>();

            Console.WriteLine("Enter grade/s or 'q' to quit");
            EnterGrades(book);
            
            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The total is {stats.Total}");
            Console.WriteLine($"The average is {stats.Average}");
            Console.WriteLine($"The HIGHEST Grade is {stats.High}");
            Console.WriteLine($"The LOWEST Grade is {stats.Low}");
            Console.WriteLine($"The Letter Grade is {stats.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input != null)
                {
                    if (input == "q")
                        break;

                    try
                    {
                        var grade = double.Parse(input);
                        book.AddGrade(grade);
                    }
                    catch (ArgumentException aex)
                    {
                        Console.WriteLine(aex.Message);
                    }
                    catch (FormatException fex)
                    {
                        Console.WriteLine(fex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("***");
                    }
                }

            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Grade was added");
        }
    }
}
#endregion