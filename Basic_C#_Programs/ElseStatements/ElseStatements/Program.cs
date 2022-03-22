using System;

namespace ElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 12;
            //int num2 = 12;
            //int num3 = 100;

            //if (num1 < num2)
            //{
            //    Console.WriteLine("1");
            //}
            //else if (num2 < num1)
            //{
            //    Console.WriteLine("2");
            //}
            //else
            //{
            //    Console.WriteLine(num3);
            //}

            int num1 = 5;
            int num2 = 10;

            string answer = num1 > num2 ? "true" : "false";
            Console.WriteLine(answer);
            
        }
    }
}
