using System;

namespace Math_And_Comparision_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparision Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string person1HourlyString = Console.ReadLine();
            decimal person1Hourly = Convert.ToDecimal(person1HourlyString);
            Console.WriteLine("Hours worked per week?");
            string person1WeeklyHoursString = Console.ReadLine();
            decimal person1WeeklyHours = Convert.ToDecimal(person1WeeklyHoursString);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string person2HourlyString = Console.ReadLine();
            decimal person2Hourly = Convert.ToDecimal(person2HourlyString);
            Console.WriteLine("Hours worked per week?");
            string person2WeeklyHoursString = Console.ReadLine();
            decimal person2WeeklyHours = Convert.ToDecimal(person2WeeklyHoursString);
            decimal person1Salary = person1Hourly * person1WeeklyHours * 52;
            decimal person2Salary = person2Hourly * person2WeeklyHours * 52;
            Console.WriteLine("Annual salary of Person 1");
            Console.WriteLine(person1Salary);
            Console.WriteLine("Annual salary of Person 2");
            Console.WriteLine(person2Salary);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool person1MakeMore = person1Salary > person2Salary;
            Console.WriteLine(person1MakeMore);
            Console.Read();
        }
    }
}
