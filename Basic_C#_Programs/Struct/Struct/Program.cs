using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNumber = new Number() { Amount = 55 };

            Console.Write(myNumber.Amount);

            Console.ReadLine();
        }
    }
}
