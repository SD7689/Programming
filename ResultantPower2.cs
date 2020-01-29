// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Resultantof2.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCsharp.JUnitTesting
{
    class ResultantPower2
    {
        public static bool isPowerOfTwo(int n)
        {

            if (n == 0)
                return false;

            while (n != 1)
            {
                if (n % 2 != 0)
                    return false;

                n = n / 2;
            }
            return true;
        }

    }
}
