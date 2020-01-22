using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class PowerOf2
    {
        public static void printTable()
        {
            Console.WriteLine("Enter the number 2 and 32");
            int pow = Utility.readInt();
            int val = 1;
            if (pow < 32)
            {
                for (int i =1; i<= pow; i++)
                {
                    val = val * 2;
                    Console.WriteLine(val);
                }
            }
            else
            {
                Console.WriteLine("Enter the correct input");
            }
        }
        
    }
}
