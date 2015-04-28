using System;
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
            Console.Write("Hello-World");
            Console.Write("\nPress g: ");
            String reply = Console.ReadLine();
            //Console.Write("\t\t"+reply);
            Console.Write("\n"+"bye g\n\n");
            //Console.ReadKey();
        }
    }
}
