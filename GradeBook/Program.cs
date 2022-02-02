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
            var book = new DiskBook("Isaac's grades");
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"The average grade is: {stats.Average}");
            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The letter grade is: {stats.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                var grade = _writer.DoubleWriter("Enter the number please or press q to quit: ");
                if (grade == 0)
                {
                    break;
                }

                book.AddGrade(grade);
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade as added");
        }
    }
}
