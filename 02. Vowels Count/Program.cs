using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            SearchForVowels(inputText);
        }

        private static void SearchForVowels(string text)
        {
            Console.WriteLine(text.Count(vowles => "aouei".Contains(vowles)));
        }
    }
}
