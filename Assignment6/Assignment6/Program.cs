//Accept a character from a user and print its ASCII value using Console Application.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Charecter to get it's Ascii Value ");
            char k = Console.ReadKey().KeyChar;

            int asciivalue = (int)k;

            Console.WriteLine($"\nAscii Value of '{k}' is {asciivalue}");

            Console.ReadKey();


        }
    }
}
