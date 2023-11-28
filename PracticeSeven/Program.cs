namespace PracticeSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter the product price:");
            int price = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Cash[1] or card[2]?");
            int payment = Convert.ToInt32(Console.ReadLine());

            if (payment == 2)
            {
                Console.WriteLine("Please, enter your account number:");
                long accountNumber = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine($"Payment done with card: {accountNumber}");
            }
            else
            {
                Console.WriteLine("Payment done with cash");
            }

            Console.ReadKey();
        }
    }
}
