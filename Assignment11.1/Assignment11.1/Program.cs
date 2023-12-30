using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Third Number : ");
            int num3 = int.Parse(Console.ReadLine());

            int max = (num1 >= num2 && num1 >= num3) ? num1 : (num2 >= num3 && num2 >= num1) ? num2 : num3;

            Console.WriteLine($"The Maximum Number Among Three Numbers is {max}");
            Console.ReadKey();
        }
    }
}
