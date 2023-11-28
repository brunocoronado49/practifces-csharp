using System;

namespace PracticeThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataOne;
            string dataTwo;
            string dataThree;
            int a;
            int b;
            int c;
            int result;

            Console.WriteLine("Enter first number:");
            dataOne = Console.ReadLine();

            Console.WriteLine("Enter first number:");
            dataTwo = Console.ReadLine();

            Console.WriteLine("Enter first number:");
            dataThree = Console.ReadLine();

            if (int.TryParse(dataOne, out a) && int.TryParse(dataTwo, out b) && int.TryParse(dataThree, out c))
            {
                result = a + b + c;
                Console.WriteLine($"The result is {result}");
            } else
            {
                Console.WriteLine("Data errors");
            }

            Console.ReadKey();
        }
    }
}
