using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HelloWorld_Gold
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = ("Hello World!!!"); 
            
            Console.ForegroundColor
             = ConsoleColor.Green;

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(100);
            }

        }
    }
}
