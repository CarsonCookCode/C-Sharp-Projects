using System;

namespace methods_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee() { FirstName = "Sample", LastName = "Student" };
            myEmployee.SayName();
            Console.ReadLine();
        }
    }
}
