using System;
using Xunit;

namespace Assessement1.Test
{
    public class UnitTest1 : Palindrome

    {
        [Fact]
        public void Test1()
        {
            int main()
            {
                isPalindrome("nurses run");
                isPalindrome("1221");
                isPalindrome("racecaR");
                return 0;
            }
        }
    }
}
