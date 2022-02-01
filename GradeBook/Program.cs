using GradeBook.Helpers;
using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        private static Writer _writer = new Writer();

        static void Main(string[] args)
        {
            var book = new Book("Isaac's grades");

            while (true)
            {
                var grade = _writer.DoubleWriter("Enter the number please or press q to quit: ");
                if (grade == 0)
                {
                    break;
                }

                book.AddGrade(grade);
            }

            var stats = book.GetStatistics();

            Console.WriteLine($"The average grade is: {stats.Average}");
            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The letter grade is: {stats.Letter}");
        }
    }
}
