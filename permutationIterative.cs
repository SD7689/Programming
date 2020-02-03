// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PermutationIterative.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programmings
{
    class permutationIterative
    {
       public static void Iterative()
        {
            Console.WriteLine("Enter a String:");
            string a = Utility.readString();
            Utility.PermutateStringTest(a);
        }
    }
}

