// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PermutationIterative.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// 
using System;
using System.Collections.Generic;
using System.Text;

namespace Programmings
{
    class permutationIterative
    {
        public static String swapString(String a, int i, int j)
        {
            char[] b = a.ToCharArray();
            char ch;
            ch = b[i];
            b[i] = b[j];
            b[j] = ch;
            //Converting characters from array into single string  
            return string.Join("", b);
        }
        public static void generatePermutation(String str, int start, int end)
        {
            //Prints the permutations  
            if (start == end - 1)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i < end; i++)
                {
                    //Swapping the string by fixing a character  
                    str = swapString(str, start, i);
                    //Recursively calling function generatePermutation() for rest of the characters   
                    generatePermutation(str, start + 1, end);
                    //Backtracking and swapping the characters again.  
                    str = swapString(str, start, i);
                }
            }
        }
    }
}

