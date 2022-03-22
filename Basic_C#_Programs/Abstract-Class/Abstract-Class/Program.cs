using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            //Employee<string> myEmployee1 = new Employee<string>() 
            //{ 
            //    FirstName = "Sample",
            //    LastName = "Student",
            //    Hired = true,
            //    Id = 1,
            //};

            //myEmployee1.Things = new List<string>() { "car", "truck", "semi" };


            //IQuittable myEmployee2 = new Employee<Person>() 
            //{ 
            //    FirstName = "Sample",
            //    LastName = "Student",
            //    Hired = true,
            //    Id = 2 
            //};

            //Employee<int> myEmployee3 = new Employee<int>() 
            //{ 
            //    FirstName = "Sample",
            //    LastName = "Student",
            //    Hired = true,
            //    Id = 3,
            //};

            //myEmployee3.Things = new List<int>() { 1, 2, 3 };

            //myEmployee1.SayName();

            //Console.WriteLine("myEmployee1 things:");
            //foreach (string thing in myEmployee1.Things)
            //{
            //    Console.WriteLine(thing);
            //}

            //Console.WriteLine("myEmployee3 things:");
            //foreach (int thing in myEmployee3.Things)
            //{
            //    Console.WriteLine(thing);
            //}

           
            //Console.WriteLine(myEmployee1.Id == myEmployee3.Id);



            //myEmployee2.Quit();

            //Console.Write("Hired Status: " + myEmployee2.Hired);

            Employee<string> employee1 = new Employee<string>()
            {
                FirstName = "Joe",
                LastName = "Smith",
                Hired = true,
                Id = 10,
            };

            Employee<string> employee2 = new Employee<string>()
            {
                FirstName = "Joe",
                LastName = "Lemon",
                Hired = true,
                Id = 11,
            };

            Employee<string> employee3 = new Employee<string>()
            {
                FirstName = "John",
                LastName = "Smith",
                Hired = true,
                Id = 12,
            };

            Employee<string> employee4 = new Employee<string>()
            {
                FirstName = "Bob",
                LastName = "Marley",
                Hired = true,
                Id = 13,
            };

            Employee<string> employee5 = new Employee<string>()
            {
                FirstName = "Tanner",
                LastName = "Lines",
                Hired = true,
                Id = 14
            };

            Employee<string> employee6 = new Employee<string>()
            {
                FirstName = "Carson",
                LastName = "Cook",
                Hired = true,
                Id = 15
            };

            Employee<string> employee7 = new Employee<string>()
            {
                FirstName = "Carol",
                LastName = "Jenkins",
                Hired = true,
                Id = 16
            };

            Employee<string> employee8= new Employee<string>()
            {
                FirstName = "King",
                LastName = "Kong",
                Hired = true,
                Id = 17
            };

            Employee<string> employee9 = new Employee<string>()
            {
                FirstName = "Zach",
                LastName = "Man",
                Hired = true,
                Id = 18
            };

            Employee<string> employee10 = new Employee<string>()
            {
                FirstName = "Joe",
                LastName = "Bodine",
                Hired = true,
                Id = 19
            };

            List<Employee<string>> employees = new List<Employee<string>>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);
            
            List <Employee<string>> joeEmployees = new List<Employee<string>>();

            foreach(Employee<string> emp in employees)
            {
                if(emp.FirstName == "Joe")
                {
                    joeEmployees.Add(emp);
                }
                
            }

            List<Employee<string>> joeEmployeesLambda = employees.FindAll(x => x.FirstName == "Joe");

            foreach (Employee<string> emp in joeEmployeesLambda)
            {
                Console.WriteLine(emp.FirstName);
            }

            List<Employee<string>> greaterThan15 = employees.FindAll(x => x.Id > 15);

            foreach (Employee<string> emp in greaterThan15)
            {
                Console.WriteLine(emp.Id);
            }

            Console.ReadLine();

        } 
    }
}
