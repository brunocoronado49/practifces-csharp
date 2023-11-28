namespace PracticeFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a city name:");
            string city = Console.ReadLine();

            Console.WriteLine($"Hello {name}, welcome to {city}");
            Console.ReadKey();
        }
    }
}
