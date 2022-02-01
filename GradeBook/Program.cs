using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Isaac's grades");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            var stats = book.GetStatistics();

            Console.WriteLine($"The average grade is: {stats.Average}");
            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The letter grade is: {stats.Letter}");
        }
    }
}
