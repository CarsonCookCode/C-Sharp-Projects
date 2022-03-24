using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your age...");
                // Try to run this block
                try
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age <= 0)
                    {
                        throw new ZeroOrNegativeException();
                    }
                    int yearBorn = 2022 - age;
                    Console.WriteLine(yearBorn);
                    
                    Console.WriteLine("You were born in the year " + yearBorn + ".");

                }
                // Catch if exception is thrown where age is 0 or less
                catch (ZeroOrNegativeException e)
                {
                    Console.WriteLine("Enter a number above 0!");
                }
                // Catch if any other exception is thrown
                catch (Exception e )
                {
                    Console.WriteLine("Something went wrong...");
                }
            Console.ReadLine();
        }
    }
}
