namespace PracticeThirdten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an option:");
            Console.WriteLine("1) Cuadrado - 2) Rectangulo - 3) Triangulo");
            int option = Convert.ToInt32(Console.ReadLine());

            CalculatePolign(option);
            Console.ReadKey();
        }

        public static void CalculatePolign(int option)
        {
            int result;

            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter side:");
                    int side = Convert.ToInt32(Console.ReadLine());

                    result = side * side;
                    Console.WriteLine($"The area of cuadrado is {result}");
                    break;

                case 2:
                    Console.WriteLine("Enter large:");
                    int large = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Enter ancho:");
                    int ancho = Convert.ToInt32(Console.ReadLine());

                    result = large * ancho;
                    Console.WriteLine($"The area of rectangulo is {result}");
                    break;

                case 3:
                    Console.WriteLine("Enter the base:");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the altura:");
                    int h = Convert.ToInt32(Console.ReadLine());

                    result = (b * h) / 2;
                    Console.WriteLine($"The area of triangulo is {result}");
                    break;
            }
        }
    }
}
