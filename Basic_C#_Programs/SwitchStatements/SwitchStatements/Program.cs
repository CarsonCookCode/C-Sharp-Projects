using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "child";
            switch (num1)
            {
                case "asdf":
                    Console.WriteLine("hi");
                    break;
                case "child":
                    Console.WriteLine("I don't exist.");
                    break;
                case "fdsa":
                    Console.WriteLine("yep");
                    break;
            }
        }
    }
}
