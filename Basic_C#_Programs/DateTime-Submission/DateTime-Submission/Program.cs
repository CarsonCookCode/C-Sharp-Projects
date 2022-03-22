using System;

namespace DateTime_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;

            Console.WriteLine(currentTime);

            Console.WriteLine("Enter a number...");

            double hoursAhead = Convert.ToDouble(Console.ReadLine());

            DateTime futureTime = new DateTime();

            currentTime = DateTime.Now;
            futureTime = currentTime.AddHours(hoursAhead);

            Console.WriteLine(futureTime);

            Console.ReadLine();
        }
    }
}
