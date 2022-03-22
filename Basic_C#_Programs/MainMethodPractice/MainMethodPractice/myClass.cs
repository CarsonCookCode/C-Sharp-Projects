using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodPractice
{
    class myClass
    {
        public int method1 (int x)
        {
            return x + 1;
        }

        public int method1(decimal x)
        {
            return Convert.ToInt32(x) + 2;
        }

        public int method1(string x)
        {
            return Convert.ToInt32(x) + 3;
        }
    }
}
