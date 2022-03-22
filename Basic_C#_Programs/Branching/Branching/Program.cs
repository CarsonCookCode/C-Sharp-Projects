using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How many pounds does your package weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
                Environment.Exit(0);
            }
            Console.WriteLine("How many inches wide is your package?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many inches tall is your package?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many inches long is your package?");
            int length = Convert.ToInt32(Console.ReadLine());
            if (width + length + height > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.Read();
                Environment.Exit(0);
            }
            int quote = width * length * height * weight / 100;

            Console.WriteLine("Package shipping cost: $" + quote + ".00");
            Console.Read();
        }
    }
}
