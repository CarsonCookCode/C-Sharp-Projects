using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee<T> : Person, IQuittable
    {
        public bool Hired { get; set; }
        public int Id { get; set; }
        public List<T> Things { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);

           
        }

        public static bool operator== (Employee<T> employee1, Employee<T> employee2)
        {

            return employee1.Id == employee2.Id;
        }

        public static bool operator!= (Employee<T> employee1, Employee<T> employee2)
        {

            return !(employee1.Id == employee2.Id);
        }

        public override bool Equals(object o)
        {
            if (o == null)
                return false;

            var second = o as Employee<T>;

            return second != null && Id == second.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }


        public void Quit()
        {
            Hired = false;
        }
    }
}
