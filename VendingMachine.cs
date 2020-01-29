// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming.JUnitTesting
{
    class VendingMachine
    {
        public static void countCurrency(int amount)
        {
            int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] noteCounter = new int[9];

            //Count notes using greedy approach
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }
            //Print Notes
            Console.WriteLine("Currency Count -->");
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + noteCounter[i]);
                }
            }
        }
    }
}
