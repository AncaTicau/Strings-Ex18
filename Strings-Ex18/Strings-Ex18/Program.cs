using System;

namespace Strings_Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that to remove the characters which have odd index values of a given string.
            string message = RemoveOddsCharacters("Ana are mere si Dana are pere.");
            Console.WriteLine(message);
        }
        public static string RemoveOddsCharacters(string input)
        {
            string result = null;

            for (int i = 0; i < input.Length; i = i + 2)
            {
                result += input[i].ToString();
            }

            return result;
        }
    }
}

