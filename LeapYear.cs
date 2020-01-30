using System;
using System.Collections.Generic;
using System.Text;
using Programmings;

namespace Programmings
{
    class LeapYear
    {
        public static void leapYear()
        {
            Console.WriteLine("Enter a year: ");
            int n = Utility.readInt();
            if (n <= 3)
                Console.WriteLine("Enter a Valid Year:");
            else
                Console.WriteLine("Valid Year" + n);
            Boolean leap = false;
            if (n % 4 == 0)
            {
                if (n % 100 == 0)
                {
                    if (n % 400 == 0)
                        leap = true;
                    else
                        leap = false;
                }
                else
                    leap = true;
            }
            else
                leap = false;
        
        if (leap)                    
             Console.WriteLine("The Given Year is Leap Year:" + n);                    
                    else 
                        Console.WriteLine("The Given Year is Not a Leap Year:" +n);
        }
    }
}
