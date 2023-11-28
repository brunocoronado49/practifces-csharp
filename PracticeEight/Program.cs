namespace PracticeEight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"bucle for: {i}");
            }

            int num = 0;
            while (num <= 100)
            {
                num++;
                Console.WriteLine($"bucle while: {num}");
            }

            for (int i = 0; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"Pares: {i}");
                }
            }

            Console.ReadKey();
        }
    }
}
