using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console App Assignment Part 1:
            Console.WriteLine("Console App Assignment Part 1:");

            string[] stringArray = { "Bob", "Frank", "Albert" };

            Console.WriteLine("Input some text...");

            string input = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += input;
            }

            for (int j = 0; j < stringArray.Length; j++)
            {
                Console.WriteLine(stringArray[j]);
            }


            Console.ReadLine();

            //Console App Assignment Part 2:
            Console.WriteLine("Console App Assignment Part 2:");

            //When condition is set to true it will make an infinite loop
            bool condition = false;
            while (condition)
            {
                Console.Write("It goes on and on and on...");
            }

            Console.ReadLine();

            //Console App Assignment Part 3:
            Console.WriteLine("Console App Assignment Part 3:");

            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int k = 0;
            while (k < 5)
            {
                Console.Write(k);
                k++;
            }

            Console.ReadLine();

            int[] myArray1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int l = 0;
            while (l <= 5)
            {
                Console.Write(l);
                l++;
            }

            Console.ReadLine();

            //Console App Assignment Part 4:
            Console.WriteLine("Console App Assignment Part 4:");

            List<string> animals = new List<string>() { "dog", "cat", "mouse", "frog"};
            Console.WriteLine("Input text that matches with an animal in the list...");

            string input1 = Console.ReadLine();
            bool matchFound = false;
            while (!matchFound)
            {
                for (int a = 0; a < animals.Count; a++)
                {
                    if (input1 == animals[a])
                    {
                        Console.WriteLine("Index of your animal: " + a);
                        matchFound = true;
                    }

                }
                if (!matchFound)
                {
                    Console.WriteLine("That animal is not on the list. Please try again...");
                }

                input1 = Console.ReadLine();
            }


            //Console App Assignment Part 5:

            Console.WriteLine("Console App Assignment Part 5:");

            List<string> vehicles = new List<string>() { "car", "truck", "van", "car", "bike" };

            Console.WriteLine("Input text that matches with a vehicle in the list...");

            string input2 = Console.ReadLine();
            bool matchFound1 = false;
            while (!matchFound1)
            {
                for (int a = 0; a < vehicles.Count; a++)
                {
                    if (input2 == vehicles[a])
                    {
                        Console.WriteLine("Index of your vehicle: " + a);
                        matchFound1 = true;
                    }

                }
                if (!matchFound1)
                {
                    Console.WriteLine("That vehicle is not on the list. Please try again...");
                }

                input2 = Console.ReadLine();
            }



            //Console App Assignment Part 6:
            
            //Possibly more complicated than necessary...


            Console.WriteLine("Console App Assignment Part 6:");

            List<string> veggies = new List<string>() { "carrot", "broccoli", "broccoli", "spinach", "kale", "garlic", "carrot" };

            List<string> countedVeggies = new List<string>() { "nothing"};

            bool isNew = true;

            foreach (string veggie in veggies)
            {
                for (int i = 0; i < countedVeggies.Count; i++)
                {
                    if (veggie == countedVeggies[i])
                    {
                        Console.WriteLine(veggie + " has been seen before.");
                        isNew = false;
                    }
                    
                }

                if (isNew)
                {
                    Console.WriteLine(veggie + " is new on the list.");
                    countedVeggies.Add(veggie);
                }
                isNew = true;

            }


            Console.ReadLine();



        }
    }
}
