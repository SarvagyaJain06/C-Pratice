using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_longest_word
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine();
            Console.WriteLine(longestWordFinder(input));
            Console.ReadLine();
        }
        static string longestWordFinder(string input)
        {
            string[] words = input.Split(new[] { " " }, StringSplitOptions.None);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            string longestWord = words[0];
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }
    }
}
