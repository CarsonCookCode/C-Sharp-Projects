using System;

namespace MainMethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass myObject = new myClass();
            int answer1 = myObject.method1(5);
            int answer2 = myObject.method1(5.0m);
            int answer3 = myObject.method1("5");


            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.ReadLine();
        }
    }
}
