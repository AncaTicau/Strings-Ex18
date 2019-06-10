using System;

namespace Strings_Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "ana are mere";
            StartsWith(givenString);
        }

        //Write a method to check whether a string starts with specified characters
        public static void StartsWith(string input)
        {
            char[] specifiedCharacters = { 'a', 'b', 'c' };
            for (int i = 0; i < specifiedCharacters.Length; i++)
            {
                if (input[0] == specifiedCharacters[i])
                {
                    Console.WriteLine("Yes, this string stars with a,b or c");
                }
            }
        }
    }
}
