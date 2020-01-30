using System;
using System.Collections.Generic;
using System.Text;

namespace Programmings
{
    class Anagram
    {
        public static void AnagramString ()
        {
            Console.WriteLine("Enter a String 1 : ");
            string str1 = Utility.readString();
            Console.WriteLine("Enter a String 2 : ");
            string str2 = Utility.readString();

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if(val1 == val2)
            {
                Console.WriteLine("Both strings Are Anagram.");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams.");
            }
        }
    }
}
