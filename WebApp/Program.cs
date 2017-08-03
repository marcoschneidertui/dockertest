using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebApp
{
    class Program
    {
        public Program()
        {
        }

        static void Main()
        {
            Console.WriteLine("Starting Application");
            Console.WriteLine("I will do nothing else than writing a console output 100 times");
            for(int i=0; i < 100; i++)
            {
                Console.WriteLine($"Now writing line {i+1}");
                System.Threading.Thread.Sleep(500);
            }
        }

    }
}
