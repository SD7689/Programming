// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySwapNibble.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Programmings
{
    class BinarySwaapNibble
    {
        public static int SwapNibble(int x)
        {
            return ((4 << x) | (x >> 4));
        }
    }
}
