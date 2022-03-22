using System;
using System.IO;

namespace Input_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number...");

            string answer = Console.ReadLine();

            File.WriteAllText(@"C:\\Users\\carso\\Logs\\log.txt", answer);

            string text = File.ReadAllText("C:\\Users\\carso\\Logs\\log.txt");
            Console.WriteLine(text);

            Console.Read();
        }
    }
}
