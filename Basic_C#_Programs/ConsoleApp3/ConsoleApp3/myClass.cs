using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class myClass
    {
        public void method1(int x)
        {
            Console.WriteLine(x / 2);
        }

        public void method2(out int y, out int z)
        {
            y = 10;
            z = 20;
        }

        public void method2(out int y, out int z, out int a)
        {
            y = 10;
            z = 20;
            a = 500;
        }
    }
}
