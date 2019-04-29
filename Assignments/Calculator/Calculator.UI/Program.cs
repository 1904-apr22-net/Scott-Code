using System;

namespace Calculator.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            Calculator calc = new Calculator();
            calc.Calculate(num);
        }
    }
}
