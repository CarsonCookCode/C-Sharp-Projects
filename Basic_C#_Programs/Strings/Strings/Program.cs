using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "My ";
            string y = "name ";
            string z = "is Carson.";
           
;            Console.WriteLine(x + y.ToUpper() + z);

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.AppendLine("World!");
            sb.AppendLine("Hello C#");
            Console.WriteLine(sb);


            Console.ReadLine();
        }
    }
}
