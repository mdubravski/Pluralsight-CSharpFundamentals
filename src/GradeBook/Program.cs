using System;

namespace GradeBook
{
    class Program
    {
        static void Main(String[] args)
        {

            var book = new Book("CS-400");
            book.AddGrade(95.6);
            book.AddGrade(88.4);
            book.AddGrade(72.3);

            book.ShowStats();
        }
    }
}
