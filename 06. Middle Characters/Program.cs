﻿using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            PrintTheMIddleCharacter(word);
        }

        private static void PrintTheMIddleCharacter(string word)
        {
            if (word.Length % 2 == 0)
            {
                Console.Write(word[word.Length / 2 - 1]);
                Console.Write(word[word.Length / 2]);
            }
            else
            {
                Console.Write(word[word.Length / 2]);
            }
        }
    }
}
