/*Write a program to calculate Net Salary of an employee using Basic Salary based on following parameters – 
HRA is 20% of basic salary.
DA is 40% of basic salary.
PF is 10% of Gross salary.
Gross Salary is Basic Salary + HRA + DA.
Net salary is Gross Salary – PF.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic Salary ");
            float bs = float.Parse(Console.ReadLine());

            float hra = bs * (20f / 100f);
            Console.WriteLine("HRA is {0} ",hra);

            float da = bs * (40f / 100f);
            Console.WriteLine("DA is {0}", da);

            float gs = bs + hra + da;
            Console.WriteLine("Gross Salary is {0}", gs);

            float pf = gs * (10f / 100f);
            Console.WriteLine("PF is {0}", pf);

            float ns = gs - pf;
            Console.WriteLine("Net Salary is {0}", ns);

            Console.ReadKey();

        }
    }
}
