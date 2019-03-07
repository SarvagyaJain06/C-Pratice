using System;

namespace Longest_word_in_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This program inputs a string and returns the longest word in a string*/
            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine();
            ChangeThirdLetter(input);
            Console.WriteLine(LongestWord(input));
            Console.ReadLine();
        }

        public static void ChangeThirdLetter(string input)
        {
            char[] character = input.ToCharArray();
            character[3] = 'c';
            foreach (char ch in character)
            {
                Console.WriteLine(ch);
            }
           
        }
        public static string LongestWord(string input)
        {
           
            
            string longestWord = "";

            

            string[] wordsOfString = input.Split(new[] { " " },StringSplitOptions.None);
            
            for (int i = 0; i < wordsOfString.Length; i++)
            {
                if (wordsOfString[i].Length > longestWord.Length)
                {
                    longestWord = wordsOfString[i];
                }

            }


            return longestWord;
        }
    }
}
