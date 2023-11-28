using System;
using System.Linq;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            VocalValidator(word);
            Console.ReadKey();
        }

        public static void VocalValidator(string word)
        {
            char[] vocals = { 'a', 'e', 'i', 'o', 'u' };
            char firstVocal = word[0];
            char secondVocal = word[word.Length - 1];

            if (word.Length > 0)
            {
                if(vocals.Contains(firstVocal) && 
                    vocals.Contains(secondVocal) && 
                    firstVocal == secondVocal)
                {
                    Console.WriteLine("YES!");
                }
                else
                {
                    Console.WriteLine("NO!");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
