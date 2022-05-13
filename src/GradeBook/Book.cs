// See https://aka.ms/new-console-template for more information

namespace GradeBook // Note: actual namespace depends on the project name.
{
    class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var average = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach (double number in grades)
            {
                highestGrade = Math.Max(number, highestGrade);
                lowestGrade = Math.Min(number, lowestGrade);
                result += number;
            }
            average = result / grades.Count;

            Console.WriteLine($"The total is {result}");
            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The HIGHEST Grade is {highestGrade}");
            Console.WriteLine($"The LOWEST Grade is {lowestGrade}");
        }
    }
}