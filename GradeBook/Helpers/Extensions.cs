using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GradeBook.Helpers
{
    public static class Extensions
    {
        public static bool IsValidNumber(this string strNumber)
        {
            var regexPattern = new Regex(@"^(\d{1,18}\.\d{1,2})$");

            if (regexPattern.IsMatch(strNumber))
            {
                return true;
            }

            return false;
        }
    }
}
