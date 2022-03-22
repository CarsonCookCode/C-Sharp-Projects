using System;

namespace Console_App_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            while (num1 != 15)
            {
                num1++;
                Console.WriteLine("This will stop at 15: " + num1);
            }
            Console.Read();

            int num2 = 0;
            do
            {
                Console.WriteLine("This will stop at 10: " + num2);
                num2++;
            } while (num2 <= 10);
        }
    }
}
