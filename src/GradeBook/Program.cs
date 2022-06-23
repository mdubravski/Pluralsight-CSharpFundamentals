using System;

namespace Gradebook
{
    class Program
    {
        static void Main(String[] args)
        {
            float x = 34.1f; 
            float y = 69.5f;
            Console.WriteLine(x+y);

            if(args.Length > 0) 
                Console.WriteLine($"Hello {args[0]}!");
            else
                Console.WriteLine("Hello!");
        }
    }
}
