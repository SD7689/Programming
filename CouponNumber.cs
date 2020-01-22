using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class CouponNumber
    {
        public static void couponNumber()
        {
			/*
	 * char array to get characters for coupen
	 */
			char[] chars = "abcdefghijklmnop".ToCharArray();
			/*
			 * length of coupen
			 */
			int max = 100000000;
			/*
			 * random value
			 */
			Random random1 = new Random();
			double d = random1.NextDouble();
			int random = (int)(d * max);
			String sb = "";
			Console.WriteLine("random double " + d + " random at start " + random);

			while (random > 0)
			{
				sb = sb + (chars[random % chars.Length]);
				random /= chars.Length;
				Console.WriteLine(random + "  " + random % chars.Length + " sb is " + sb);
			}

			String couponCode = sb.ToString();
			Console.WriteLine(value: "Coupon Code: " + couponCode);
		}
	}
}
