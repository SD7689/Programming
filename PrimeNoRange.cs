// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeNoRange.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// 
using System;
using System.Collections.Generic;
using System.Text;

namespace Programmings
{
    class PrimeNoRange
    {
        public static void Range()
        {
            int num, i, ctr, stno, enno;

            Console.Write("\n\n");
            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input starting number of range:  ");
            stno = 1;
            Console.Write("Input ending number of range : ");
            enno = 1000;
            Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);

            for (num = stno; num <= enno; num++)
            {
                ctr = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0}  ", num);
            }
            Console.Write("\n");
        }
    }
}