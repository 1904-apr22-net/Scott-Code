using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.UI
{
    public class Calculator
    {
        public void Calculate(int n)
        {
            int num = n - (n%3);
            while (num > 2)
            {
                Console.WriteLine(num);
                num -= 3;
            }
        }
    }
}
