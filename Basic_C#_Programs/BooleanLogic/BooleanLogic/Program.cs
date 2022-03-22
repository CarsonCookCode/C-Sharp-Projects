using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            int age = Convert.ToInt16(ageString);
            Console.WriteLine("Have you ever had a DUI? Enter \"true\" or \"false\"");
            string DUIString = Console.ReadLine();
            bool DUI = Convert.ToBoolean(DUIString);
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsString = Console.ReadLine();
            int tickets = Convert.ToInt16(ticketsString);
            bool qualified = age > 15 && DUI == false && tickets <= 3;
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);

            Console.Read();

        }
    }
}
