// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Programming.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class Harmonic
    {
        public static void harmonic(int N)
        {
            double i, h = 0;
            for (i = 1; i <= N; i++)
               h = h + 1 / i;

            Console.WriteLine("HArmonic no is : " + h);


        }


    }
}
