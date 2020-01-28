using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming.JUnitTesting
{
    class BinarySwaapNibble
    {
        public static int SwapNibble(int x)
        {
            return ((x & 0x0F) << 4 |
            (x & 0xF0) >> 4);
        }
    }
}
