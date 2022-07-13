using System;

namespace GradeBook
{
    class Program
    {
        static void Main(String[] args)
        {
            var book = new InMemoryBook("CS-400");
            book.GradeAdded += OnGradeAdded;

            EnterGrade(book);
            book.ShowStats();
        }

        private static void EnterGrade(IBook book)
        {
            
            while (true)
            {
                System.Console.WriteLine("Enter a grade or 'q' to exit");
                var input = Console.ReadLine() ?? throw new ArgumentNullException();
                if (input == "q") break;
                try
                {
                    book.AddGrade(double.Parse(input));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }

    }
}
