using System;

namespace PracticeTwelve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if(IsPrime(i))
                {
                    Console.WriteLine($"{i} is number prime");
                }
            }

            Console.ReadKey();
        }

        public static bool IsPrime(int number)
        {
            if(number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
