using System;

namespace methodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass myObject = new myClass();

            myObject.method1(15, 50);

            myObject.method1(x: 200, y: 300);

            Console.ReadLine();
        }
    }
}
