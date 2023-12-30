/*
 * Write a program to find maximum of 3 numbers using – 
If – else.
Conditional operators.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number :");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Third Number :");
            int num3 = int.Parse(Console.ReadLine());

            int maximum;

            if (num1 >= num2 && num1 >= num3)
            {
                maximum = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                maximum = num2;
            }
            else
            {
                maximum = num3;
            }
            Console.WriteLine($"The Maximum Number Among Three Numbers {num1}, {num2} and {num3} is {maximum}");
            Console.ReadKey();
        }
    }
}
