using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExceptionDemo
{
    class MyHttpError
    {
        public string ExceptionMessage { get; set; }
        public string ExceptionType { get; set; }
        public Exception InnerException { get; set; }
        public string Message { get; set; }
        public string MessageDetail { get; set; }
        public string StackTrace { get; set; }
    }
}
