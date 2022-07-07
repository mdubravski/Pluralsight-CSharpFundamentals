namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;

        public Book(string name)
        {
            Name = name;
            grades = new List<double>();
        }

        public void

        public void AddGrade(double grade)
        {
            if(grade > 100 || grade < 0) throw new Exception("Invalid Grade");
            grades.Add(grade);
        } 

        public Stats GetStats()
        {
            Stats s = new();
            s.High = double.MinValue;
            s.Low = double.MaxValue;

            
            for(int i=0; i<grades.Count; i++)
            {
                s.High = Math.Max(grades[i], s.High);
                s.Low= Math.Min(grades[i], s.Low);
                s.Average = grades.Average();
            }
            
            return s;
        }

        public void ShowStats()
        {
            Stats s = GetStats();
            Console.WriteLine($"Highest Grade: {s.High:N1}");
            Console.WriteLine($"Lowest Grade: {s.Low:N1}");
            Console.WriteLine($"Average Grade: {s.Average:N1}");
        }
    }
}