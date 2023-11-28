namespace PracticeEleven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci(50);
            Console.ReadKey();
        }

        public static void Fibonacci(int number)
        {
            int a = 0;
            int b = 1;
            Console.Write($" {a} {b} ");

            for(int i = 0; i < number; i++)
            {
                int next = a + b;
                Console.Write($" {next} ");
                a = b;
                b = next;
            }
        }
    }
}
