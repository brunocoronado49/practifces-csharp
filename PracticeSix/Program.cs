namespace PracticeSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number of day [1-7]: ");
            string userData = Console.ReadLine();

            if(int.TryParse(userData, out int day))
            {
                if (day > 5)
                {
                    Console.WriteLine("Weekend");
                }
                else
                {
                    Console.WriteLine("Not weekend");
                }
            }
            else
            {
                Console.WriteLine("error!");
            }

            Console.ReadKey();
        }
    }
}
