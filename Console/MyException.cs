using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExceptionDemo
{
    class MyException : Exception
    {
        private readonly string stackTrace;

        public MyException(string message, string stackTrace)
            : base(message)
        {
            // TODO: Complete member initialization
            this.stackTrace = stackTrace;
        }

        public override string StackTrace
        {
            get { return this.stackTrace; }
        }
    }
}
