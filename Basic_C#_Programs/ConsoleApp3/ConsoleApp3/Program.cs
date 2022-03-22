using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass myObject = new myClass();

            Console.WriteLine("Enter a number...");

            int x = Convert.ToInt32(Console.ReadLine());
            myObject.method1(x);

            Console.WriteLine("Enter two numbers...");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            myObject.method2(out y, out z);
            Console.WriteLine(y);
            Console.WriteLine(z);

            int a;
            myObject.method2(out y, out z, out a);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);


            staticClass.method1();

            Console.ReadLine();
        }
    }
}
