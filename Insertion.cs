// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Insertion.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Programmings
{
    class Insertion
    {
        public static void InsertionSort()
        {
            int[] arr = new int[10] { 23, 9, 56, 86, 78, 45, 3, 45, 32, 23 };
            int n = 10, j, i, val, flag;
            Console.WriteLine("Insertion Sort -");
            Console.WriteLine("Intial Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
                Console.WriteLine(" Sorted array is :");
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i] + "");
                }
            }
        }
    }
}
