// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Bubblesort.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Programmings
{
    class BubbleSort
    {
        public static void Bubblesort()
        {
            int[] arr = {67,58,45,36,13};
            int temp;
            for(int j=0; j<arr.Length-1; j++)
            {
                for(int i=0; i<arr.Length-1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array:");
            foreach (int p in arr)
            {
                Console.WriteLine(p + " ");
            }
        }
    }
}
