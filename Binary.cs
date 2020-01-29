// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Binary.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming.JUnitTesting
{
    class Binary
    {
        public static void DecToBinary(int n)
        {
            int[] binaryNum = new int[32];
            int i = 0;
            while(n > 0)
            {
                binaryNum[i] = n % 2;
                n = n / 2;
                i++;
            }
            for(int j = i-1; j>=0; j--)
            {
                Console.Write(binaryNum[j]);
            }
        }
    }
}
