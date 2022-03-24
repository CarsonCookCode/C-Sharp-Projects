using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    // Custom exception
    public class ZeroOrNegativeException : Exception
    {
        public ZeroOrNegativeException()
            : base() { }
        public ZeroOrNegativeException(string message)
            : base(message) { }
    }
}
