
//File Header//
//Name: Program.cs
//Purpose: Main();
// implements basic Question/Response system using console I/O.

// list of libraries - add only what is needed. and mention why.
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("HelloWorld");
            Console.Write("\nPress g: \n");
            String reply = Console.ReadLine();
            Console.Write("\t\t"+reply);
            Console.ReadKey();
        }
    }
}
