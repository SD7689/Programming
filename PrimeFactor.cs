using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class PrimeFactor
    {
        public static void Primefactor(int n)
        {
            //Console.WriteLine("Enter a No.");
          //  int n = Utility.readInt();
           
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }

            //For odd No.
            for(int i = 3; i<=Math.Sqrt(n); i += 2)
            {
                while(n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= 2;
                }
            }
            if (n > 2)
                Console.Write(n);
        }
    }
}
