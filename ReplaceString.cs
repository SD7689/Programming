// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ReplaceString.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class ReplaceString
    {
        public static void Replace()
        {
            string name = "Hello Username , Welcome to .net Programming!!";
            Console.WriteLine("Enter a name to be replaced");
            string replaceName = Utility.readString();
            string replace = "";
            if (replaceName.Length < 3)
                Console.WriteLine("Enter a Valid String of More than 3 Character:");
            else
                replace = name.Replace("Username", replaceName);
            Console.WriteLine(replace);
        }
             

    }
}