/*
 * Using a switch case 
 * write a menu driven program to 
 * perform basic calculations of two user entered numbers.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter Your Choice from 1-5");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Exit");
                    break;
                }

                Console.WriteLine("Enter First Number : ");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Number : ");
                double num2 = double.Parse(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"Addition of Two Numbers {num1} and {num2} is {result}");
                        break;
                    case 2:
                        result = num2 - num1;
                        Console.WriteLine($"Subtraction of Two Numbers {num1} and {num2} is {result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"Multiplication of Two Numbers {num1} and {num2} is {result}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Undefined !!");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Division of Two Numbers {num1} and {num2} is {result}");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid Choice Please Choose among 1 to 5");
                            break;
                        }
                }
                        Console.ReadKey();
            }
        }
    }
}
