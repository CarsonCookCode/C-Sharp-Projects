using System;

namespace Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week...");

            // If user enters a day return day
            try
            {
                string stringDay = Console.ReadLine();

                if (stringDay == "Sunday" ||
                stringDay == "Monday" ||
                stringDay == "Tuesday" ||
                stringDay == "Wednesday" ||
                stringDay == "Thursday" ||
                stringDay == "Friday" ||
                stringDay == "Saturday")
                {
                    Enum.TryParse(stringDay, out Days day);
                    Console.WriteLine(day);
                }
                
                else
                {
                    throw new Exception("Incorrect input data type");
                }


             }
            // else throw error message
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week with correct spelling and capitalization...");
            }

            Console.ReadLine();
        }
    }
}
