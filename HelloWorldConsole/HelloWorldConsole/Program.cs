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
            Console.Write("HelloWorld");
            Console.Write("\n\tPress g: \n");
            String reply = Console.ReadLine();
            Console.Write("\t\t"+reply);
            Console.ReadKey();
        }
    }
}
