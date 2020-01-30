// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemperatureConversion.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Programmings
{
    class TemperatureConversion
    {
       public static void Conversion()
       {
          
         double fahrenheit;
         Console.WriteLine("Eneter a Temp in celcius");
         double celsius = Utility.readDouble();
         Console.WriteLine("Celsius: " + celsius);

         fahrenheit = (celsius * 9) / 5 + 32;
         Console.WriteLine("Fahrenheit: " + fahrenheit);

            Console.WriteLine("Eneter a Temp in Fahrenheit");
            double Fahrenheit = Utility.readDouble();
            Console.WriteLine("Celsius: " + celsius);

            celsius = (Fahrenheit * 9) / 5 + 32;
            Console.WriteLine("celsius: " + celsius);

            //    Console.ReadLine();

        }
    }
}
