namespace PracticeFvie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bigger;
            
            Console.WriteLine("Enter a number:");
            string numberOne = Console.ReadLine();
            
            Console.WriteLine("Enter other number:");
            string numberTwo = Console.ReadLine();

            if(int.TryParse(numberOne, out int n1) 
                && int.TryParse(numberTwo, out int n2))
            {
                if(n1 > n2)
                {
                    Console.WriteLine($"The number {n1} is bigger");
                }
                else
                {
                    Console.WriteLine($"The number {n2} is bigger");
                }
            }

            Console.ReadKey();
        }
    }
}
