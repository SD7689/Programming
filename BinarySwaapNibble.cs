// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySwapNibble.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming.JUnitTesting
{
    class BinarySwaapNibble
    {
        public static int SwapNibble(int x)
        {
            return ((4 << x) | (x >> 4));
        }
    }
}
