using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {

        string[] stringArray = { "dog", "cat", "mouse" };
        Console.WriteLine("Select an index of a string array: (0-2)");
        int index = Convert.ToInt32(Console.ReadLine());
        if (index == 0 || index == 1 || index == 2)
        {
            Console.WriteLine(stringArray[index]);
        } else
        {
            Console.WriteLine("You must choose an index of 0, 1, or 2");
        }
        

        int[] intArray = { 1, 2, 4};
        Console.WriteLine("Select an index of an integer array: (0-2)");
        int index1 = Convert.ToInt32(Console.ReadLine());
        if (index1 == 0 || index1 == 1 || index1 == 2)
        {
            Console.WriteLine(intArray[index1]);
        }
        else
        {
            Console.WriteLine("You must choose an index of 0, 1, or 2");
        }

        List<string> myList = new List<string>();
        myList.Add("Frank");
        myList.Add("Bobby");
        myList.Add("Albert");
        Console.WriteLine("Select an index (0-2).");
         int index2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(myList[index2]);
        Console.ReadLine();








        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //Console.WriteLine(intList[0]);

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //Console.WriteLine(numArray2[3]);
        //Console.ReadLine();
    }
}
