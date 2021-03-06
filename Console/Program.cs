﻿using BusinessLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Globalization;

namespace ConsoleExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            const string server = "http://exceptionserver";
            Console.WriteLine("1. Throw on this thread");
            Console.WriteLine("2. Throw on new Thread thread");
            Console.WriteLine("3. Throw on async thread");
            Console.WriteLine("4. Get WCF exception");
            Console.WriteLine("5. Get WebAPI HTTP 500 error with HTTP client");
            Console.WriteLine("6. Get WebAPI bare exception with HTTP client");
            Console.WriteLine("7. Get WebAPI HTTP exception with HTTP client");
            Console.WriteLine("8. Get WebAPI bare exception with HTTP client and deserialize it");
            Console.WriteLine("9. Get a business layer exception");
            Console.WriteLine("10. Get a business layer exception in French");
            string input = Console.ReadLine();
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
            else if (input == "4")
            {
                using (ExceptionService.ExceptionServiceClient client = new ExceptionService.ExceptionServiceClient())
                {
                    client.DoWork();
                }
            }
            else if (input == "5")
            {
                using (HttpClient client = new HttpClient())
                {
                    var respTask = client.GetAsync(String.Format("{0}/mvc/api/exception", server));
                    respTask.Wait();
                    var result = respTask.Result;
                    var contentTask = result.Content.ReadAsStringAsync();
                    contentTask.Wait();
                    Console.WriteLine("Ha! There is no exception. Only an HTTP status of {0} ({0:d}) with a message of \"{1}\", and content \"{2}\"", result.StatusCode, result.ReasonPhrase, contentTask.Result);
                }
            }
            else if (input == "6")
            {
                using (HttpClient client = new HttpClient())
                {
                    var respTask = client.GetAsync(String.Format("{0}/mvc/api/exception", server));
                    respTask.Wait();
                    respTask.Result.EnsureSuccessStatusCode();
                }
            }
            else if (input == "8")
            {
                using (HttpClient client = new HttpClient())
                {
                    var respTask = client.GetAsync(String.Format("{0}/mvc/api/exception", server));
                    respTask.Wait();
                    if (!respTask.Result.IsSuccessStatusCode)
                    {
                        string responseBody = respTask.Result.Content.ReadAsStringAsync().Result;
                        var error = JsonConvert.DeserializeObject<MyHttpError>(responseBody);
                        throw new MyException(error.ExceptionMessage, error.StackTrace);
                    }
                }
            }
            else if (input == "9")
            {
                try
                {
                    new CustomerOperations().SaveCustomer(new CustomerDto
                    {
                        FirstName = "Joey",
                        Id = 1,
                        LastName = "Shabadoo"
                    });
                }
                catch (BusinessLayerException ex)
                {
                    Console.WriteLine(String.Format("Error code: {0} Message: {1}", ex.Data[BusinessLayerException.ReasonKey], ex.Message));
                }
            }
            else if (input == "10")
            {
                try
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-CA");
                    new CustomerOperations().SaveCustomer(new CustomerDto
                    {
                        FirstName = "Joey",
                        Id = 1,
                        LastName = "Shabadoo"
                    });
                }
                catch (BusinessLayerException ex)
                {
                    Console.WriteLine(String.Format("Error code: {0} Message: {1}", ex.Data[BusinessLayerException.ReasonKey], ex.Message));
                }
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
