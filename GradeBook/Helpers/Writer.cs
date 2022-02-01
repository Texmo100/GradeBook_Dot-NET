using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.Helpers
{
    public class Writer
    {
        public double DoubleWriter(string msg)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(msg);
                    var userInput = Console.ReadLine();
                    var lowerCase = userInput.ToLower();

                    if (lowerCase.Equals("q"))
                    {
                        return 0;
                    }

                    if (userInput.IsValidNumber())
                    {
                        return Convert.ToDouble(userInput);
                    }
                    else
                    {
                        Console.WriteLine("Retry again please, your input is invalid");
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong during the execution: {ex.Message}");
                }
            }
        }
    }
}
