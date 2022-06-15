using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double result = Factorial(firstNum);
            double result2 = Factorial(secondNum);
            Console.WriteLine($"{result / result2:f2}");
        }

        private static double Factorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }
    }
}
