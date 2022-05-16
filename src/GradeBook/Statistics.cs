namespace GradeBook
{
    public class Statistics
    {
        public Statistics()
        {
            Total = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
            Count = 0;
        }
        
        public double Average
        {
            get
            {
                return Total / Count;
            }
        }
        public double Total;
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';
                    case var d when d >= 80.0:
                        return 'B';
                    case var d when d >= 70.0:
                        return 'C';
                    case var d when d >= 60.0:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }
        public int Count;

        public void Add(double number)
        {
            Total += number;
            Count += 1;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }

    }
}