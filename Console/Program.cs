using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Throw on this thread");
            Console.WriteLine("2. Throw on new Thread thread");
            Console.WriteLine("3. Throw on async thread");
            string input = Console.ReadLine();
            //char inputChar = (char)input;
            if (input == "1")
            {
                throw new Exception("Oh noooo!");
            }
            else if (input == "2")
            {
                var thread = new Thread(ThreadProcedure);
                thread.Start();
            }
            else if (input == "3")
            {
                AsyncProcedure().Wait();
            }
            else
            {
                Console.WriteLine("Exiting normally.");
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
