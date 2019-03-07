using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_Words_Of_Sentance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sentence");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new[] { " " }, StringSplitOptions.None);
            string reversedString = "";
            int numberOfWords = words.Length;
            while (numberOfWords > 0)
            {
                reversedString += words[numberOfWords - 1] + " ";
                numberOfWords--;
            }
            Console.WriteLine(reversedString);
            Console.ReadLine();
        }
    }
}
