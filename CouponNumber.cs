// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CoupanNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Programmings
{
    class CouponNumber
    {
        public static void couponNumber()
        {
            //Created a Random object
            Random r = new Random();
            string couponNo = "";
            int Count = 0;
            Console.WriteLine("Enter length of Coupon Number: ");
            int N = Utility.readInt();
            for (int i = 0; i < N; i++)
            {
                int ran = r.Next(0, 10);
                Count += 1;
                if (couponNo.Contains(ran.ToString()))
                {
                    i -= 1;
                }
                else
                {
                    couponNo += ran;
                }
                Console.WriteLine("Total Randoms needed:" + Count);
                Console.WriteLine("Coupon Code: " + couponNo);
            }
        }
    }
}

