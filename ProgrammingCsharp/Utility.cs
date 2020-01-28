using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCsharp
{

    class Utility
    {
        public static int readInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static String readString()
        {
            String s = Console.ReadLine();
            return s;
        }
        public static double readDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static bool readBool()
        {
            return Convert.ToBoolean(Console.ReadLine());
        }
    }
}
