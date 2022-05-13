// See https://aka.ms/new-console-template for more information

namespace GradeBook // Note: actual namespace depends on the project name.
{
    public class Book
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

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.Total = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (double number in grades)
            {
                result.High = Math.Max(number, result.High);
                result.Low = Math.Min(number, result.Low);
                result.Total += number;
            }
            result.Average = result.Total / grades.Count;

            return result;
        }
    }
}