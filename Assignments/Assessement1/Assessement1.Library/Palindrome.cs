using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assessement1.Library
{
    public class Palindrome
    {
        void isPalindrome(string str[])
        {
            string normalized = Regex.Replace(str, @"/s", "");
            int l = 0;
            int h = str.Length - 1;

            
            while (h > l)
            {
                if (str[l++] != str[h--])
                {
                    Console.WriteLine("{0} is Not Palindrome", str);
                    return;
                }
            }
            Console.WriteLine("{0} is palindrome", str);
        }
    }
}
