using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExceptionDemo
{
    public class MyException : Exception
    {
        private readonly string stackTrace;

        public MyException(string message, string stackTrace)
            : base(message)
        {
            this.stackTrace = stackTrace;
        }

        // You can't set the StackTrace value on System.Exception, but you can override it
        public override string StackTrace
        {
            get { return this.stackTrace; }
        }
    }
}
