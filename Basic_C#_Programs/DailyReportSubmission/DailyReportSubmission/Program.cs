using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportSubmission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumberAnswer = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNumberAnswer);
            Console.WriteLine("Do you need help with anything? Please answer \u201Dtrue\u201D or \u201Dfalse.\u201D");
            string needHelpAnswer = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(needHelpAnswer);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudiedAnswer = Console.ReadLine();
            decimal hoursStudied = Convert.ToDecimal(hoursStudiedAnswer);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
