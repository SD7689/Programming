// --------------------------------------------------------------------------------------------------------------------
// <copyright file "WindChill.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class WindChill
    {
        public static void Windchill(double f, double ws)
        {
            double w = 35.74 + 0.62158 * f + (0.4275 * f - 35.75) * Math.Pow(ws, 0.16);
            Console.WriteLine(w);

            try
            {
                if (Math.Abs(f) > 50 || ws > 120 || ws < 3)
                {
                    Console.WriteLine("Enter Correct Output");
                }
                else
                {
                    Windchill(f, ws);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("enter proper output");
            }
        }
    }
}

