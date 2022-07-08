using System;

namespace GradeBook
{
    class Program
    {
        static void Main(String[] args)
        {
            var book = new Book("CS-400");
            while(true)
            {
                System.Console.WriteLine("Enter a grade or 'q' to exit");
                var input = Console.ReadLine() ?? throw new ArgumentNullException();
                if(input == "q") break;
                try
                {
                book.AddGrade(double.Parse(input));
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // ..
                }
            }
            book.ShowStats();
        }
    }
}
