using System;
using System.Collections.Generic;

namespace methodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            intClass myObject = new intClass();


            Console.WriteLine("Input two numbers, one at a time. Second number is optional...");

            int x = Convert.ToInt32(Console.ReadLine());
            try
            {
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(myObject.method1(x, y));
            }
            catch (System.FormatException e)
            {
                Console.WriteLine(myObject.method1(x));
            }

            Console.ReadLine();

        }
       
    }
}
