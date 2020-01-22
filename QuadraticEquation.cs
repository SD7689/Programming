using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class QuadraticEquation
    {
        public static void Quadratic()
        {
            double a, b, c, D, X1, X2;
            Console.WriteLine("Enter Value of a , b & c:");
            a = Utility.readDouble();
            b = Utility.readDouble();
            c = Utility.readDouble();
            if(a != 0)
            {
                D = b * b - 4 * a * c;
            }
            else
            {
                Console.WriteLine("Quadratic Eq not Possible.");
            }
            D = b * b - 4 * a * c;
            if (D >= 0)
            {
                D = Math.Sqrt(D);
                X1 = (-b + D) / (2 * a);
                X2 = (-b - D) / (2 * a);
                Console.WriteLine("Root X1 = " + X1);
                Console.WriteLine("Root X2 = " + X2);
            }else
            {
                Console.WriteLine("Roots are not Possible.");
            }
        } 
    }
}
