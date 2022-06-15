using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isPasswordvalidLength = ValidatePasswordLength(password);
            bool isPasswordvalidSymbols = ValidatePasswordSymbols(password);
            bool isPasswordvalidDigits = ValidatePasswordDigits(password);

            if (!isPasswordvalidLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordvalidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isPasswordvalidDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isPasswordvalidDigits && isPasswordvalidLength && isPasswordvalidSymbols)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ValidatePasswordDigits(string password)
        {
             int count = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }
            return count >= 2;
        }

        private static bool ValidatePasswordSymbols(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValidatePasswordLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}
