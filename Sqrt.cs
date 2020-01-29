// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SquareRoot.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
using ProgrammingCsharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming.JUnitTesting
{
    class Sqrt
    {
        public static void Root()
        {
            Console.WriteLine("Eneter a Non-Negative No. :");
            double c = Utility.readDouble();
            double epsilon = 1.0e-15;  // relative error tolerance
            double t = c;              // estimate of the square root of c

            // repeatedly apply Newton update step until desired precision is achieved
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }

            // print out the estimate of the square root of c
            Console.WriteLine(t);


        }
    }
}
