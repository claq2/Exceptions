using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("1. Throw on this thread");
            System.Console.WriteLine("2. Throw on new Thread thread");
            System.Console.WriteLine("3. Throw on async thread");
            int input = System.Console.Read();
            char inputChar = (char)input;
            if (inputChar == '1')
            {
                throw new Exception("Oh noooo!");
            }
            else if (inputChar == '2')
            {
                var thread = new Thread(ThreadProcedure);
                thread.Start();
            }
            else if (inputChar == '3')
            { 
                AsyncProcedure().Wait();
            }
            
        }

        static async Task AsyncProcedure()
        {
            throw new Exception("Oh noooo!");
        }

        private static void ThreadProcedure(object state)
        {
            throw new Exception("Oh noooo!");
        }
    }
}
