using System;
using System.Linq;

namespace PracticeTen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordOne = "amor";
            string wordTwo = "roma";

            bool result = IsAnagram(wordOne, wordTwo);
            Console.WriteLine($"The result of {wordOne} and {wordTwo} is {result}");
            Console.ReadKey();
        }

        public static bool IsAnagram(string wordOne, string wordTwo)
        {
            if(wordOne.ToLower() == wordTwo.ToLower())
            {
                return false;
            }

            if(wordOne.Length != wordTwo.Length)
            {
                return false;
            }

            char[] arrWordOne = wordOne.ToCharArray();
            char[] arrWordTwo = wordTwo.ToCharArray();

            Array.Sort(arrWordOne);
            Array.Sort(arrWordTwo);

            return arrWordOne.SequenceEqual(arrWordTwo);
        }
    }
}
