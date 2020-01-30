// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DayOfWeek.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Programmings
{
    class DayOfWeek
    {
        public static void checkday()
        {
            Console.WriteLine("Enter date :");
            int d = Utility.readInt();
            Console.WriteLine("Enter Month Number :");
            int m = Utility.readInt();
            Console.WriteLine("Enter year :");
            int y = Utility.readInt();
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] Day = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thrusday", "Friday", "Saturday" };
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine("It's " + Day[d0] + " on " + d + " " + month[m - 1] + ", " + y);
        }
    }
}
