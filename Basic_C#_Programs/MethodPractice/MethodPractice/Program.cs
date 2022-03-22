using System;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass newClass = new myClass();

            Console.WriteLine("Enter an integer...");
            int parameter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(parameter + " + 5 = " + newClass.add5(parameter));
            Console.WriteLine(parameter + " - 5 = " + newClass.subtract5(parameter));
            Console.WriteLine(parameter + " * 5 = " + newClass.multiplyBy5(parameter));

            Console.ReadLine();
        }
    }
}
