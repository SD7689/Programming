using ProgrammingCsharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming.JUnitTesting
{
    class MonthlyPayment
    {
        public static void Payment()
        {
            Console.WriteLine("Enter loan Amount:");
            double P = Utility.readDouble();
            Console.WriteLine("Enter a year :");
            double Y = Utility.readDouble();
            Console.WriteLine("Enter Intrest Rate:");
            double R = Utility.readDouble();

            double n = 12 * Y;
            double r = R / (12 * 100);

            double payments = (P * r) / (1 - Math.Pow(1 + r, -n));
            double interest = payments * n - P;

            Console.WriteLine("Monthly payment is: " +payments);
            Console.WriteLine("Intrest rate is: " + interest);
        }
    }
}
