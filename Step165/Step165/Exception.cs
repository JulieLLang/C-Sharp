using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step165
{
    public class ExceptionClass : Exception
    {
        public ExceptionClass()
            : base() { }
        public ExceptionClass(string message)
            : base(message) { }
    }
}