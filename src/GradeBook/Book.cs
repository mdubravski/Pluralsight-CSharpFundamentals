namespace GradeBook
{
    public class Book
    {
        const string CATEGORY = "Science";
        private List<double> grades;
        public string Name 
        {
            get; 
            private set;
        }
        public Book(string name)
        {
            Name = name;
            grades = new List<double>();
        }

        public void AddGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                case 'F':
                    AddGrade(50);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            if(grade > 100 || grade < 0) throw new ArgumentException($"Invalid {nameof(grade)}");
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

            switch(s.Average)
            {
                case var avg when avg > 90.0:
                    s.Letter = 'A';
                    break;
                case var avg when avg >= 80.0:
                    s.Letter = 'B';
                    break;
                case var avg when avg >= 70.0:
                    s.Letter = 'C';
                    break;
                case var avg when avg >= 60.0:
                    s.Letter = 'D';
                    break;
                default:
                    s.Letter = 'F';
                    break;
            }
            
            return s;
        }

        public void ShowStats()
        {
            Stats s = GetStats();
            Console.WriteLine($"Showing stats for {this.Name}");
            Console.WriteLine($"Highest Grade: {s.High:N1}");
            Console.WriteLine($"Lowest Grade: {s.Low:N1}");
            Console.WriteLine($"Average Grade: {s.Average:N1}");
            Console.WriteLine($"Letter Grade: {s.Letter}");
        }
    }
}