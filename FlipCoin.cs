﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programmings
{
    class FlipCoin
    {
        public static void flipCoin()
        {
            int head = 0, Tail = 0;
            Random r = new Random();
            Console.WriteLine("Enter No. of time To flip a coin");
            int n = Utility.readInt();
            for(int i =0; i < n; i++)
            {
                int num = r.Next(1,10);
                if(num > 5)
                {
                    head++;
                }
                else
                {
                    Tail++;
                }
            }
            Console.WriteLine($"The percentage of Head is : {(double)head * 100 / n}");
            Console.WriteLine($"The percentage of Tail is : {(double)Tail * 100 / n}");
        }

    }
}