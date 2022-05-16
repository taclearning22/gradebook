// See https://aka.ms/new-console-template for more information

namespace GradeBook // Note: actual namespace depends on the project name.
{
    public class Book
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        private List<double> grades;
        private string name;
        public string Name
        {
            get; 
            set;
        }
        public const string CATEGORY = "Science";

        // public void AddLetterGrade(char letter)
        // {
        //     switch(letter)
        //     {
        //         case 'A':
        //             AddGrade(90);
        //             break;
        //         case 'B':
        //             AddGrade(80);
        //             break;
        //         case 'C': 
        //             AddGrade(70);
        //             break;
        //         case 'D': 
        //             AddGrade(60);
        //             break;
        //         default: 
        //             AddGrade(40);
        //             break;
        //     }
        // }

        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
                
            else
                throw new ArgumentException($"Invalid {nameof(grade)}");
        }

        public event GradeAddedDelegate GradeAdded;

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

            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }
    }
}