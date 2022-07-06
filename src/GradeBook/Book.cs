namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            if(grade > 100 || grade < 0) throw new Exception("Invalid Grade");
            grades.Add(grade);
        } 

        public void ShowStats()
        {
            double highGrade = double.MinValue;
            double lowGrade = double.MaxValue;
            double avgGrade = 0.0;
            
            foreach(var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
                avgGrade = grades.Average();
            }
            Console.WriteLine($"Highest Grade: {highGrade:N1}");
            Console.WriteLine($"Lowest Grade: {lowGrade:N1}");
            Console.WriteLine($"Average Grade: {avgGrade:N1}");
        }
    }
}