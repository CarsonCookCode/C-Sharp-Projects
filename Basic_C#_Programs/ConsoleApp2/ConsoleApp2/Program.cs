using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myInts = new List<int>() { 5, 10, 20, 35, 40 };
            List<int> newInts = new List<int>();
            int dividend = 1;

            try
            {

                myInts.ForEach(Console.WriteLine);

                Console.WriteLine("Enter an integer to divide this list by...");
                dividend = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < myInts.Count; i++)
                {
                    myInts[i] = (myInts[i] / dividend);

                }
                myInts.ForEach(Console.WriteLine);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program completed");
            }

            

            Console.ReadKey();
        }
    }
}
