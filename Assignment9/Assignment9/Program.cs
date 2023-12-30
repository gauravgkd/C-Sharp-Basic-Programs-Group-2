/*
 * Write a program to accept the basic salary and total sales amount from a salesperson and calculate commission according to the sales amount. Display the net salary and commission earned.
Sales Amount in Rs.	Commission(%) on Sales
5,000 to 7,500	3
7,501 to 10,500	8
10,501 to 15,000	11
15,000 to above	15
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic Salary ");
            double bs = double.Parse(Console.ReadLine());  // bs = Basic Salary

            Console.WriteLine("Enter Total Sales Amount ");
            double s = double.Parse(Console.ReadLine());   // s = Sales Amount

            double cr = GetCommissionRate(s);  // cr = Commission Rate
            double ce = s * (cr / 100);        // ce = Comission Earned 

            double ns = bs + ce;               // ns = Net Salary

            Console.WriteLine($"Commission Rate : {cr}%");
            Console.WriteLine($"Commission Earned : {ce}");
            Console.WriteLine($"Net Salary : {ns}");

            Console.ReadKey();
        }
        static double GetCommissionRate(double s)
        {
            if (s >= 5000 && s <= 7500)
            {
                return 3;
            }
            else if (s >= 7501 && s <= 10500)
            {
                return 8;
            }
            else if (s >= 10501 && s <= 15000)
            {
                return 11;
            }
            else if (s > 15000)
            {
                return 15;
            }
            else
            {
                return 0;
            }
        }
    }
}
